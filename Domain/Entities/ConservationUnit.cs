using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("ucs")]
    public class ConservationUnit : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }

        [Column("nome_uc")]
        public string UCName { get; private set; } = string.Empty;

        [Column("categoria")]
        public string Category { get; private set; } = string.Empty;

        [Column("grupo")]
        public string Group { get; private set; } = string.Empty;

        [Column("esfera")]
        public string Realm { get; private set; } = string.Empty;

        [Column("cria_ano")]
        public string YearCreation { get; private set; } = string.Empty;

        [Column("cria_ato")]
        public string ActCreation { get; private set; } = string.Empty;

        [Column("cd_cnuc")]
        public string CNUCCode { get; private set; } = string.Empty;

        [Column("org_gestor")]
        public string ManagingBody { get; private set; } = string.Empty;

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
        protected ConservationUnit() { }
    }
}
