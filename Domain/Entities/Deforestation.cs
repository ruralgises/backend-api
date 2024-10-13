using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("desmatamentos")]
    public class Deforestation : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }

        [Column("year")]
        public int Year { get; private set; }

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
        protected Deforestation() {}
    }
}
