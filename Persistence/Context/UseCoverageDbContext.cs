using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class UseCoverageDbContext : DbContext
    {
        public UseCoverageDbContext(DbContextOptions options) : base(options){}
        DbSet<UseCoverage> useCoverages {  get; set; }
    }
}
