using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;

namespace Domain.Interfaces.Repositories.Bases
{

    public interface ILocationsGeoSpatialBaseRepository<T> where T : class, LocationGeoSpatialBase
    {
        Task<T> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);

        Task<T> GetByName(string name, CancellationToken cancellationToken);
    }
}
