using Domain.Entities.BasesEntities;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Utils;

namespace Persistence.Repositories.Bases
{
    public class LocationsGeoSpatialBaseRepository<T> : ILocationsGeoSpatialBaseRepository<T> where T : class, LocationGeoSpatialBase
    {
        protected readonly LocationDbContext _context;
        protected readonly TableUltils _tableUltils;

        public LocationsGeoSpatialBaseRepository(LocationDbContext context, TableUltils tableUltils)
        {
            _context = context;
            _tableUltils = tableUltils;
        }

        public async Task<T> GetByName(string name, CancellationToken cancellationToken)
        {
            return await GetByNameQueryble(name).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<T> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return await GetByGeometryQueryable(geometry).FirstOrDefaultAsync(cancellationToken);
        }

        public IQueryable<T> GetByNameQueryble(string name)
        {
            return _context.Set<T>()
                .FromSqlRaw($"SELECT * FROM {_tableUltils.GetTableName<T>(_context)} WHERE unaccent({_tableUltils.GetColumnName<T>(_context, "Name")}) = unaccent('{name}')")
                .Take(1);
        }

        public IQueryable<T> GetByGeometryQueryable(Geometry geometry)
        {
            var rBase = _context.Set<T>().Where(item => item.Geom != null && item.Geom.Intersects(geometry));
            return rBase.OrderByDescending(item => item.Geom!.Intersection(geometry).Area).Take(1);
        }
    }
}
