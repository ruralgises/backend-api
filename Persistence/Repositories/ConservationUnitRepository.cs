using Domain.Entities;
using Domain.Interfaces.Repositories;
using Persistence.Context;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class ConservationUnitRepository : GeoSpatialBaseIntersectionRepository<ConservationUnit>, IConservationUnitsRepository
    {
        public ConservationUnitRepository(ConservationUnitDbContext context) : base(context) { }
    }
}
