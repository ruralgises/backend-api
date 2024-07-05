using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BasesEntities
{
    public abstract class GeoSpatialBaseIntersection : GeoSpatialBase
    {
        public double AreaIntersectHa { get; set; }
    }
}
