using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using NetTopologySuite.Index.HPRtree;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class GeoEntityWithAreaIntersection<T> where T : GeoSpatialBaseIntersection
    {
        public T Entity { get; set; }
        public double AreaIntersection { get; set; }
        public double AreaTotal { get; set; }
    }

    public class GeoSpatialBaseIntersectionRepository<T> : GeoSpatialBaseRepository<T>, IGeoSpatialBaseIntersectionRepository<T> where T : GeoSpatialBaseIntersection
    {
        public GeoSpatialBaseIntersectionRepository(AppDbContext context) : base(context)
        {}

        public override async Task<IList<T>> GetByGeometry(Geometry geometry, CancellationToken cancellationToken)
        {
            var results = await base.GetByGeometryQueryable(geometry).Select(item => new GeoEntityWithAreaIntersection<T>
            {
                Entity = item,
                AreaIntersection = geometry.Intersection(item.Geom).Area,
                AreaTotal = item.Geom!.Area
            }).ToListAsync(cancellationToken);

            foreach (var item in results)
            {
                item.Entity.AreaIntersectHa = item.AreaIntersection;
                item.Entity.AreaTotal = item.AreaTotal;
            }

            return results.Select(item => item.Entity).ToList();
        }
    }
}
