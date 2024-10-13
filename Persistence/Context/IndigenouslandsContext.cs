using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class IndigenouslandsContext : DbContext
    {
        public IndigenouslandsContext(DbContextOptions<IndigenouslandsContext> options) : 
            base(options){}

        DbSet<Indigenouslands> Indigenouslands { get; set; }
    }
}
