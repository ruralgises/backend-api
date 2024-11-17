using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class SettlementsRepository : ISettlementsRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<Settlement> _geoSpatialBaseIntersectionRepository;
        public SettlementsRepository(GeoSpatialBaseIntersectionRepository<Settlement, SettlementsDbContext> geoSpatialBaseIntersectionRepository)
        {
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<Settlement>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
