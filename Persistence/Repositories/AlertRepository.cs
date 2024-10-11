using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositories.Bases;

namespace Persistence.Repositories
{
    public class AlertRepository : GeoSpatialBaseIntersectionRepository<Alert>, IAlertRepository
    {
        public AlertRepository(AlertDbContext context) : base(context)
        {
        }
    }
}
