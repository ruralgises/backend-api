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
    [Table("messoregioes")]
    public class Messorerion : LocationGeoSpatialBase
    {
        [Column("cd_meso")]
        public string Code { get; private set; } = string.Empty;

        [Column("nm_meso")]
        public string Name { get; private set; } = string.Empty;

        protected Messorerion() { }
    }
}
