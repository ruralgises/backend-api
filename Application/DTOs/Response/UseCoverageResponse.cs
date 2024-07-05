using Application.DTOs.Response.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class UseCoverageResponse : GeoSpatialBaseIntersectionResponse
    {
        public int Class { get; set; }
        public string Name { get; set; }
    }
}
