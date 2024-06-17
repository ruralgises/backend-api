using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("desmatamentos")]
    public class Deforestation : GeoSpatialBaseIntersection
    {
        [Column("year")]
        public string Year { get; private set; } = string.Empty;

        [Column("area_km")]
        public double AreaTotalKM { get; private set; }

        protected Deforestation() {}
    }
}
