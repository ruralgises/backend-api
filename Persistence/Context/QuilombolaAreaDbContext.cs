﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class QuilombolaAreaDbContext : DbContext
    {
        public QuilombolaAreaDbContext(DbContextOptions<QuilombolaAreaDbContext> options) : base(options) { }

        public DbSet<QuilombolaArea> QuilombolaAreas { get; set; }
    }
}
