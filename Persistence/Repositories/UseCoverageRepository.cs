using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class UseCoverageRepository : IUseCoverageRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<UseCoverage> _geoSpatialBaseIntersectionRepository;
        public UseCoverageRepository(GeoSpatialBaseIntersectionRepository<UseCoverage, UseCoverageDbContext> geoSpatialBaseIntersectionRepository)
        {
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<UseCoverage>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
