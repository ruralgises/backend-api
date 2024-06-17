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
    internal class MessoreionsRepository : LocationsGeoSpatialBaseRepository<Messorerion>, IMessoreionRepository
    {
        public MessoreionsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
