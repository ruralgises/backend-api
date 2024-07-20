using Domain.Entities.BasesEntities;
using Domain.Interfaces.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using NetTopologySuite.Index.HPRtree;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Bases
{
    public class GeoSpatialBaseIntersectionRepository<T> : IGeoSpatialBaseRepository<T> where T : class, GeoSpatialBaseIntersection
    {
        private readonly DbContext _context;

        public GeoSpatialBaseIntersectionRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            var wktGeometry = geometry.AsText(); // Converte a geometria para WKT
            var tableName = GetTableName<T>(); // Obtém o nome da tabela dinamicamente

            var results = await _context.Set<T>()
                .FromSqlRaw($@"
                SELECT 
                    *,
                    ST_Area(ST_Intersection(ST_Transform(geom, 32723), ST_Transform(ST_GeomFromText('{wktGeometry}', 4674), 32723))) / 10000 AS AreaIntersectHa
                FROM 
                    {tableName}
                WHERE 
                    ST_Intersects(geom, ST_GeomFromText('{wktGeometry}', 4674))")
                .ToListAsync(cancellationToken);

            return results.ToList();
        }

        private string GetTableName<TEntity>() where TEntity : class
        {
            // Usa a API de metadados do Entity Framework Core para encontrar o nome da tabela
            var entityType = _context.Model.FindEntityType(typeof(TEntity));
            if (entityType == null)
            {
                throw new InvalidOperationException($"Cannot find table name for entity type {typeof(TEntity).FullName}");
            }
            var schema = entityType.GetSchema();
            var tableName = entityType.GetTableName();
            return string.IsNullOrEmpty(schema) ? tableName : $"{schema}.{tableName}";
        }
    }
}
