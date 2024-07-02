﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class SettlementsDbContext : DbContext
    {
        public SettlementsDbContext(DbContextOptions<SettlementsDbContext> options) : base(options) { }
        public DbSet<Settlement> Settlements { get; set; }
    }
}
