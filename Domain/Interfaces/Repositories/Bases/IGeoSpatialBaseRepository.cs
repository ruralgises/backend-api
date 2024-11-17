using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;

namespace Domain.Interfaces.Repositories.Bases
{
    public interface IGeoSpatialBaseRepository<T>
        where T : IGeoSpatialBase
    {
        Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);
    }
}
