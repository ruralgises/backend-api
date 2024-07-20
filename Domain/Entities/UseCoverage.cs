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

        public double AreaIntersectHa { get; init; }

        [Column("class")]
        public int Class { get; set; }

        [Column("class_name")]
        public string Name { get; set; }
    }
}
