using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using NetTopologySuite.Geometries;

namespace Persistence.Repositories
{
    internal class MicroregionsRepository : IMicroregionRepository
    {
        private readonly ILocationsGeoSpatialBaseRepository<Microregion> _locationsGeoSpatialBaseRepository;
        public MicroregionsRepository(ILocationsGeoSpatialBaseRepository<Microregion> locationsGeoSpatialBaseRepository)
        {
            _locationsGeoSpatialBaseRepository = locationsGeoSpatialBaseRepository;
        }
        public Task<Microregion> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByGeometry(geometry, cancellationToken);
        }

        public Task<Microregion> GetByName(string name, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByName(name, cancellationToken);
        }
    }
}
