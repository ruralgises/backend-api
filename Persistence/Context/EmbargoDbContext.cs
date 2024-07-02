using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class EmbargoDbContext : DbContext
    {
        public EmbargoDbContext(DbContextOptions<EmbargoDbContext> options) : base(options) { }

        public DbSet<Embargo> Embargoes { get; set; }
    }
}
