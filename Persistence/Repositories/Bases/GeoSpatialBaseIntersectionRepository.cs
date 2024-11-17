using Domain.Entities.BasesEntities;
using Domain.Interfaces.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Utils;

namespace Persistence.Repositories.Bases
{
    public class GeoSpatialBaseIntersectionRepository<T, Db> : IGeoSpatialBaseIntersectionRepository<T> 
        where Db : DbContext 
        where T : class, GeoSpatialBaseIntersection
    {
        private readonly DbContext _context;
        private readonly TableUltils _tableUltils;
        public GeoSpatialBaseIntersectionRepository(Db context, TableUltils tableUltils)
        {
            _context = context;
            _tableUltils = tableUltils;
        }

        public async Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            var wktGeometry = geometry.AsText(); // Converte a geometria para WKT
            var tableName = _tableUltils.GetTableName<T>(_context); // Obtém o nome da tabela dinamicamente

            var results = await _context.Set<T>()
                .FromSqlRaw($@"
                    WITH area_data AS (
                        SELECT 
                            *,
                            Round((ST_Area(ST_Intersection(ST_Transform(geom, 32723), ST_Transform(ST_GeomFromText('{wktGeometry}', 4674), 32723))) / 10000)::numeric, 2) AS area_intersect_ha
                        FROM 
                            {tableName}
                        WHERE 
                            ST_Intersects(geom, ST_GeomFromText('{wktGeometry}', 4674))
                    )
                    SELECT 
                        *,
                        Round((area_intersect_ha / (ST_Area(ST_Transform(ST_GeomFromText('{wktGeometry}', 4674), 32723)) / 10000 )* 100)::numeric, 2) AS percentage_of_the_property_area
                    FROM 
                        area_data;")
                .ToListAsync(cancellationToken);

            var r = results.ToList();

            return r;
        }
    }
}
