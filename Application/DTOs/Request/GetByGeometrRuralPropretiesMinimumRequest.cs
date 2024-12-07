using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request
{
    public class GetByGeometryRuralPropretiesMinimumRequest
    {
        [Required]
        public Geometry Geometry { get; set; }
        public int? Skip { get; set; } = null;
        public int? Take { set; get; } = null;
    }
}
