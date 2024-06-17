using Domain.Entities;
using Domain.Interfaces.Repositories;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class MicroregionsRepository : LocationsGeoSpatialBaseRepository<Microregion>, IMicroregionRepository
    {
        public MicroregionsRepository(AppDbContext context) : base(context)
        {}
    }
}
