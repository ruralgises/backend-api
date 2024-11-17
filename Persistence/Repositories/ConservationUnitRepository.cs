using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class ConservationUnitRepository : IConservationUnitsRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<ConservationUnit> 
            _geoSpatialBaseIntersectionRepository;
        public ConservationUnitRepository(
            GeoSpatialBaseIntersectionRepository<ConservationUnit, ConservationUnitDbContext> geoSpatialBaseIntersectionRepository
            ) {
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<ConservationUnit>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
