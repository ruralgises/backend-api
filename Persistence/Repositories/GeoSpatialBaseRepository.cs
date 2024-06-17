using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public abstract class GeoSpatialBaseRepository<T> : IGeoSpatialBaseRepository<T> where T : GeoSpatialBase
    {
        protected readonly AppDbContext _context;

        public GeoSpatialBaseRepository(AppDbContext context) {
            _context = context;
        }

        public virtual async Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            return await this.GetByGeometryQueryable(geometry).ToListAsync(cancellationToken);
        }

        public virtual IQueryable<T> GetByGeometryQueryable(Geometry geometry)
        {
            return this._context.Set<T>().Where(item => item.Geom != null && item.Geom.Intersects(geometry));
        }
    }
}