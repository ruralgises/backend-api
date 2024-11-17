using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using NetTopologySuite.Geometries;

namespace Persistence.Repositories
{
    public class MunicipalitiesRepository : IMunicipalitiesRepository
    {
        private readonly ILocationsGeoSpatialBaseRepository<Municipality> _locationsGeoSpatialBaseRepository;
        public MunicipalitiesRepository(ILocationsGeoSpatialBaseRepository<Municipality> locationsGeoSpatialBaseRepository)
        {
            _locationsGeoSpatialBaseRepository = locationsGeoSpatialBaseRepository;
        }

        public Task<Municipality> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByGeometry(geometry, cancellationToken);
        }

        public Task<Municipality> GetByName(string name, CancellationToken cancellationToken)
        {
            return _locationsGeoSpatialBaseRepository.GetByName(name, cancellationToken);
        }
    }
}
