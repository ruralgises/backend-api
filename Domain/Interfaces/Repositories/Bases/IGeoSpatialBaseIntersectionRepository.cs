using Domain.Entities.BasesEntities;

namespace Domain.Interfaces.Repositories.Bases
{
    public interface IGeoSpatialBaseIntersectionRepository<T> : IGeoSpatialBaseRepository<T>
        where T : IGeoSpatialBase
    {
    }
}
