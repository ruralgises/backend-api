using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("uso_cobertura")]
    public class UseCoverage : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }

        [Column("class")]
        public int Class { get; init; }

        [Column("class_name")]
        public string Name { get; init; }

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
    }
}
