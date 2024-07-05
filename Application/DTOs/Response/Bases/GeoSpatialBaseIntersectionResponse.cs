using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Bases
{
    public abstract class GeoSpatialBaseIntersectionResponse
    {
        public double AreaIntersectHa { get; init; }
    }
}
