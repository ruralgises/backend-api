﻿using Domain.Entities;
using NetTopologySuite.Geometries;

namespace Domain.Interfaces.Repositories
{
    public interface IRuralPropertiesRepository
    {
        Task<IList<RuralProperty>> GetByCode(string code, int? Skip, int? Take, CancellationToken cancellationToken);
        Task<IList<RuralProperty>> GetByGeometry(Geometry geometry, int? Skip, int? Take, CancellationToken cancellationToken);
        public Task<RuralProperty?> GetByCode(string code, CancellationToken cancellationToken);
    }
}
