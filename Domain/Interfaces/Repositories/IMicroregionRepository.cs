using Domain.Entities;
using Domain.Interfaces.Repositories.Bases;

namespace Domain.Interfaces.Repositories
{
    public interface IMicroregionRepository : ILocationsGeoSpatialBaseRepository<Microregion>
    {
    }
}
