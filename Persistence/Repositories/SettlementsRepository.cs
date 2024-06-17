using Domain.Entities;
using Domain.Interfaces.Repositories;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class SettlementsRepository : GeoSpatialBaseIntersectionRepository<Settlement>, ISettlementsRepository
    {
        public SettlementsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
