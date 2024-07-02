using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class InformationDatabaseDbContext : DbContext
    {
        public InformationDatabaseDbContext(DbContextOptions<InformationDatabaseDbContext> options) : base(options) { }

        public DbSet<InformationDatabase> informationDatabases { get; set; }
    }
}
