﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Context;
using Persistence.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ConservationUnitRepository : GeoSpatialBaseIntersectionRepository<ConservationUnit>, IConservationUnitsRepository
    {
        public ConservationUnitRepository(ConservationUnitDbContext context) : base(context) { }
    }
}
