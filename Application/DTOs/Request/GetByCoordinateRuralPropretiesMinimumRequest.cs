using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class GetByCoordinateRuralPropretiesMinimumRequest
    {
        [Required]
        public Coordinate Coordinate { get; set; }
        public int? Skip { get; set; } = null;
        public int? Take { set; get; } = null;
    }
}
