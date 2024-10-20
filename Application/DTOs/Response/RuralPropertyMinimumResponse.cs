using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class RuralPropertyMinimumResponse
    {
        public string ThemeName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public double AreaHa { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;

        public Geometry? Geom { get; set; }
    }
}
