using Domain.Entities;
using Domain.Interfaces.Repositories.Bases;

namespace Domain.Interfaces.Repositories
{
    public interface IAlertRepository : IGeoSpatialBaseIntersectionRepository<Alert>
    {
    }
}
