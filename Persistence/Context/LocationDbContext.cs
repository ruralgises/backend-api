using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class LocationDbContext : DbContext
    {
        public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options) { }

        public DbSet<Messoregion> Messorerions { get; set; }
        public DbSet<Microregion> Microregiones { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Municipality>()
                .Property(m => m.Name).HasColumnName("nm_mun");

            modelBuilder.Entity<Municipality>()
                .Property(m => m.Code).HasColumnName("cd_mun");

            modelBuilder.Entity<Microregion>()
                .Property(m => m.Name).HasColumnName("nm_micro");

            modelBuilder.Entity<Microregion>()
                .Property(m => m.Code).HasColumnName("cd_micro");

            modelBuilder.Entity<Messoregion>()
                .Property(m => m.Name).HasColumnName("nm_meso");

            modelBuilder.Entity<Messoregion>()
                .Property(m => m.Code).HasColumnName("cd_meso");
        }
    }
}
