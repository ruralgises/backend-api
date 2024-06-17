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
        [Column("cd_micro")]
        public string Code { get; private set; } = string.Empty;

        [Column("nm_micro")]
        public string Name { get; private set; } = string.Empty;

        protected Microregion() { }
    }
}
