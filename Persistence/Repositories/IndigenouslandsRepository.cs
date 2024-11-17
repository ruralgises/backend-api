using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class IndigenouslandsRepository : IIndigenouslandsRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<Indigenouslands> 
            _geoSpatialBaseIntersectionRepository;
        public IndigenouslandsRepository(
            GeoSpatialBaseIntersectionRepository<Indigenouslands, IndigenouslandsContext> geoSpatialBaseIntersectionRepository
        ){
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<Indigenouslands>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
