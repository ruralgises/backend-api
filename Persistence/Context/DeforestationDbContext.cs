using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class DeforestationDbContext : DbContext
    {
        public DeforestationDbContext(DbContextOptions<DeforestationDbContext> options) : base(options) { }

        public DbSet<Deforestation> Deforestations { get; set; }
    }
}
