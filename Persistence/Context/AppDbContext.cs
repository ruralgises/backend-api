using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ConservationUnit> ConservationUnits { get; set; }
        public DbSet<Deforestation> Deforestations { get; set; }
        public DbSet<Embargo> Embargoes { get; set; }
        public DbSet<Messorerion> Messorerions { get; set; }
        public DbSet<Microregion> Microregiones { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<QuilombolaArea> QuilombolaAreas { get; set; }
        public DbSet<RuralProperty> RuralProperties { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
    }
}
