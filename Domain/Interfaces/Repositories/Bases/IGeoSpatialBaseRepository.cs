using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;

namespace Domain.Interfaces.Repositories.Bases
{

    public interface IGeoSpatialBaseRepository<T> where T : GeoSpatialBase
    {
        Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);
    }
}
