using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetByCoordinateRuralPropretiesRequest
    {
        public Coordinate? Coordinate { get; set; }
        public int? Skip { get; set; }
        public int? Take { set; get; }
    }
}
