﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class RuralPropertiesDbContext : DbContext
    {
        public RuralPropertiesDbContext(DbContextOptions<RuralPropertiesDbContext> options) : base(options) { }
        
        public DbSet<RuralProperty> RuralProperties { get; set; }
        
    }
}
