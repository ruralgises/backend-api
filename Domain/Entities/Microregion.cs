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
    [Table("microrregioes")]
    public class Microregion : LocationGeoSpatialBase
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }
        [Column("cd_micro")]
        public string Code { get; init; }
        [Column("nm_micro")]
        public string Name { get; init; }
        protected Microregion() { }
    }
}
