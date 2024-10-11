using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("alertas")]

    public class Alert : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }

        [Column("codealerta")]
        public int CodeAlert { get; init; }

        [Column("datadetec")]
        public DateOnly DetectDate { get; init; }

        [Column("dtpubli")]
        public DateOnly PublicationDate { get; init; }

        [Column("vpressao")]
        public string VectorPressure { get; init; }
        [Column("fonte")]
        public string Font {  get; init; }

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
    }
}
