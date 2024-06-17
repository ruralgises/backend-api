﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class DeforestationRepository : GeoSpatialBaseIntersectionRepository<Deforestation>, IDeforestationsRepository
    {
        public DeforestationRepository(AppDbContext context) : base(context) { }
    }
}
