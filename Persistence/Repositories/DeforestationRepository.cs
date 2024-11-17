using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class DeforestationRepository : IDeforestationsRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<Deforestation> _geoSpatialBaseIntersectionRepository;
        public DeforestationRepository(GeoSpatialBaseIntersectionRepository<Deforestation, DeforestationDbContext> geoSpatialBaseIntersectionRepository) {
        
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<Deforestation>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
