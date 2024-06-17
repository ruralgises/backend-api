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
    [Table("municipios")]
    public class Municipality : LocationGeoSpatialBase
    {
        [Column("cd_mun")]
        public string Code { get; private set; } = string.Empty;

        [Column("nm_mun")]
        public string Name { get; private set; } = String.Empty;

        protected Municipality() { }
    }
}
