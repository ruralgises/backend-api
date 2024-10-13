using Domain.Entities;
using Domain.Interfaces.Repositories.Bases;
using NetTopologySuite.Geometries;

namespace Domain.Interfaces.Repositories
{
    public interface IIndigenouslandsRepository : IGeoSpatialBaseRepository<Indigenouslands>
    {
    }
}
