﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IMunicipalitiesRepository : IGeoSpatialBaseRepository<Municipality>
    {
    }
}
