using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    internal class EmbagosRepository : IEmbargoesRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<Embargo> _geoSpatialBaseIntersectionRepository;
        public EmbagosRepository(GeoSpatialBaseIntersectionRepository<Embargo, EmbargoDbContext> geoSpatialBaseIntersectionRepository)
        {
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<Embargo>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
