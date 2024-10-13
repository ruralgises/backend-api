using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("terras_indigenas")]
    public class Indigenouslands: GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }
        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }

        [Column("terrai_nom")]
        public string LandName { get; init; }

        [Column("etnia_nome")]
        public string EthnicityName { get; init; }

        [Column("fase_ti")]
        public string IndigenousLandCreationPhase { get; init; }

        [Column("modalidade")]
        public string Modality { get; init; }

        [Column("undadm_cod")]
        public string adminUnitCode { get; init; }

        [Column("undadm_nom")]
        public string adminUnitName { get; init; }

        [Column("undadm_sig")]
        public string adminUnitAcronym { get; init; }
    }
}
