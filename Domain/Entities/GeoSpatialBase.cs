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
    public abstract class GeoSpatialBase
    {
        [Key]
        [Column("gid")]
        public int Id { get; protected set; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; protected set; }
    }
}
