using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories.Bases
{

    public interface ILocationsGeoSpatialBaseRepository<T> where T : LocationGeoSpatialBase
    {
        Task<T> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);

        Task<T> GetByName(string name, CancellationToken cancellationToken);
    }
}
