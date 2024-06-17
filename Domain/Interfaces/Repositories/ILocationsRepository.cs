using Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ILocationsRepository
    {
        Task<Entities.Location> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);
    }
}
