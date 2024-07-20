using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BasesEntities
{
    public interface GeoSpatialBaseIntersection : IGeoSpatialBase
    {
        public double AreaIntersectHa { get; init; }
    }
}
