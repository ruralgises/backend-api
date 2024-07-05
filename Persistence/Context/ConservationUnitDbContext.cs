using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ConservationUnitDbContext : DbContext
    {

        public ConservationUnitDbContext(DbContextOptions<ConservationUnitDbContext> options) : base(options) { }
        public DbSet<ConservationUnit> ConservationUnits { get; set; }

    }
}
