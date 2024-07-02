using Domain.Entities.BasesEntities;
using Domain.Interfaces.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Context;

namespace Persistence.Repositories.Bases
{
    public abstract class LocationsGeoSpatialBaseRepository<T> : ILocationsGeoSpatialBaseRepository<T> where T : LocationGeoSpatialBase
    {
        protected readonly LocationDbContext _context;

        public LocationsGeoSpatialBaseRepository(LocationDbContext context)
        {
            _context = context;
        }       

        public async Task<T> GetByName(string name, CancellationToken cancellationToken)
        {
            return await GetByNameQueryble(name).FirstOrDefaultAsync(cancellationToken);
        }

        async Task<T> ILocationsGeoSpatialBaseRepository<T>.GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return await GetByGeometryQueryable(geometry).FirstOrDefaultAsync(cancellationToken);
        }

        public IQueryable<T> GetByNameQueryble(string name)
        {
            return _context.Set<T>().Where(x => x.Name == name).Take(1);
        }

        public IQueryable<T> GetByGeometryQueryable(Geometry geometry)
        {
            var rBase = _context.Set<T>().Where(item => item.Geom != null && item.Geom.Intersects(geometry));
            return rBase.OrderByDescending(item => item.Geom!.Intersection(geometry).Area).Take(1);
        }
    }
}
