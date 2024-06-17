using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("propriedades_rurais")]
    public class RuralProperty : GeoSpatialBaseIntersection
    {
        [Column("nom_tema")]
        public string ThemeName { get; private set; } = string.Empty;

        [Column("cod_imovel")]
        public string Code { get; private set; } = string.Empty;

        [Column("num_area")]
        public double AreaHa { get; private set; }

        [Column("ind_status")]
        public string Status { get; private set; } = string.Empty;

        [Column("ind_tipo")]
        public string Type { get; private set; } = string.Empty;

        [Column("des_condic")]
        public string Condition { get; private set; } = string.Empty;

        protected RuralProperty() { }
    }
}
