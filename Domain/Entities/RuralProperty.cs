using Domain.Entities.BasesEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("imoveis_rurais")]
    public class RuralProperty : GeoSpatialBase
    {
        [Column("nom_tema")]
        public string ThemeName { get; private set; } = string.Empty;

        [Column("cod_imovel")]
        public string Code { get; private set; } = string.Empty;

        [Column("num_area")]
        public double AreaHa { get; set; }

        [Column("ind_status")]

        public string Status { get; private set; } = string.Empty;

        [Column("ind_tipo")]
        public string Type { get; private set; } = string.Empty;

        [Column("des_condic")]
        public string Condition { get; private set; } = string.Empty;

        [Column("municipio")]
        public string Municipio { get; private set; } = string.Empty;

        protected RuralProperty() { }
    }
}
