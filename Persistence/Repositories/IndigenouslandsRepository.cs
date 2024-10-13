using Domain.Entities;
using Domain.Interfaces.Repositories;
using Persistence.Context;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class IndigenouslandsRepository : GeoSpatialBaseIntersectionRepository<Indigenouslands>, IIndigenouslandsRepository
    {
        public IndigenouslandsRepository(IndigenouslandsContext context) : base(context)
        {
        }
    }
}
