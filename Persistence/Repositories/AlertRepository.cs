using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class AlertRepository : IAlertRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<Alert> _geoSpatialBaseRepository;
        public AlertRepository(GeoSpatialBaseIntersectionRepository<Alert, AlertDbContext> geoSpatialBaseIntersectionRepository)
        {
            _geoSpatialBaseRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<Alert>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseRepository.GetByGeometry(geometry, cancellationToken);
        }
    }
}
