using Domain.Entities;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Persistence")]

namespace Domain.Interfaces.Repositories
{
    
    public interface IGeoSpatialBaseRepository<T> where T : GeoSpatialBase
    {
        Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken);
        internal IQueryable<T> GetByGeometryQueryable(Geometry geometry);
    }
}
