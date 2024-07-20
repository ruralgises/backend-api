using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using NetTopologySuite.Shape;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("area_de_quilombolas")]
    public class QuilombolaArea : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        public double AreaIntersectHa { get; init; }

        [Column("nr_process")]
        public string ProcessNumber { get; private set; } = string.Empty;

        [Column("nm_comunid")]
        public string CommunityName { get; private set; } = string.Empty;

        [Column("nr_familia")]
        public int FamilyNumber { get; private set; }

        [Column("dt_decreto")]
        public string DecreeDate { get; private set; } = string.Empty;

        [Column("esfera")]
        public string Realm { get; private set; } = string.Empty;

        [Column("fase")]
        public string Phase { get; private set; } = string.Empty;

        [Column("responsave")]
        public string Responsible { get; private set; } = string.Empty;

        protected QuilombolaArea() { }
    }
}
