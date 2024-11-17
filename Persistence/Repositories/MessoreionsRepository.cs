using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using NetTopologySuite.Geometries;

namespace Persistence.Repositories
{
    internal class MessoreionsRepository : IMessoreionRepository
    {
        private readonly ILocationsGeoSpatialBaseRepository<Messoregion> _locationsGeoSpatialBaseRepository;
        public MessoreionsRepository(ILocationsGeoSpatialBaseRepository<Messoregion> locationsGeoSpatialBaseRepository)
        {
            _locationsGeoSpatialBaseRepository = locationsGeoSpatialBaseRepository;
        }

        public Task<Messoregion> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByGeometry(geometry, cancellationToken);
        }

        public Task<Messoregion> GetByName(string name, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByName(name, cancellationToken);
        }
    }
}
