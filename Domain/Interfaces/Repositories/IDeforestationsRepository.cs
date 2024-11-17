﻿using Domain.Entities;
using Domain.Interfaces.Repositories.Bases;

namespace Domain.Interfaces.Repositories
{
    public interface IDeforestationsRepository : IGeoSpatialBaseIntersectionRepository<Deforestation>
    {
    }
}
