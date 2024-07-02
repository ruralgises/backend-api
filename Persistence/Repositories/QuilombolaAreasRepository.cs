using Domain.Entities;
using Domain.Interfaces.Repositories;
using Persistence.Context;
using Persistence.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class QuilombolaAreasRepository : GeoSpatialBaseIntersectionRepository<QuilombolaArea>, IQuilombolaAreasRepository
    {
        public QuilombolaAreasRepository(QuilombolaAreaDbContext context) : base(context)
        {
        }
    }
}
