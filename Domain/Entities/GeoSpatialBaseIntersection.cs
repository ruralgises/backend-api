using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class GeoSpatialBaseIntersection : GeoSpatialBase
    {
        [NotMapped]
        public double AreaIntersectHa;

        [NotMapped]
        public double AreaTotal;
    }
}
