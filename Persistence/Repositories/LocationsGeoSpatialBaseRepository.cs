using Domain.Entities;
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
    public abstract class LocationsGeoSpatialBaseRepository<T> : GeoSpatialBaseRepository<T>, IGeoSpatialBaseRepository<T> where T : LocationGeoSpatialBase
    {
        public LocationsGeoSpatialBaseRepository(AppDbContext context) : base(context)
        {
        }

        public override IQueryable<T> GetByGeometryQueryable(Geometry geometry)
        {
            var rBase = base.GetByGeometryQueryable(geometry);
            return rBase.OrderByDescending(item => item.Geom!.Intersection(geometry).Area).Take(1);
        }
    }
}
