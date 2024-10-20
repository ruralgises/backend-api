﻿using Domain.Entities;
using Domain.Interfaces.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IAlertRepository : IGeoSpatialBaseRepository<Alert>
    {
    }
}
