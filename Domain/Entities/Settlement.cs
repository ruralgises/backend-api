using Domain.Entities.BasesEntities;
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
    [Table("assentamentos")]
    public class Settlement : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")] 
        public double AreaIntersectHa { get; init; }

        [Column("cd_sipra")]
        public string CodeSIPRA {  get; private set; } = string.Empty;

        [Column("nome_proje")]
        public string NameProject { get; private set; } = string.Empty;

        [Column("num_famili")]
        public int FamilyNumber { get; private set; }

        [Column("data_de_cr")]
        public string CreationDate { get; private set; } = string.Empty;

        [Column("forma_obte")]
        public string WayObtaining {  get; private set; } = string.Empty;

        [Column("data_obten")]
        public string DateObtaining { get; private set; } = string.Empty;

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
        protected Settlement() { }
    }
}
