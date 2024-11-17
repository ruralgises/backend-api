using Domain.Entities;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Bases;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class QuilombolaAreasRepository : IQuilombolaAreasRepository
    {
        private readonly IGeoSpatialBaseIntersectionRepository<QuilombolaArea> _geoSpatialBaseIntersectionRepository;
        public QuilombolaAreasRepository(
            GeoSpatialBaseIntersectionRepository<QuilombolaArea, QuilombolaAreaDbContext> geoSpatialBaseIntersectionRepository
            )
        {
            _geoSpatialBaseIntersectionRepository = geoSpatialBaseIntersectionRepository;
        }

        public Task<IList<QuilombolaArea>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return _geoSpatialBaseIntersectionRepository.GetByGeometry( geometry, cancellationToken);
        }
    }
}
