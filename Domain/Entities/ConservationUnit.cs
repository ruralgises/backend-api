using Domain.Entities.BasesEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("ucs")]
    public class ConservationUnit : GeoSpatialBaseIntersection
    {   
        [Column("nome_uc")]
        public string UCName { get; private set; } = string.Empty;

        [Column("categoria")]
        public string Category { get; private set; } = string.Empty;

        [Column("grupo")]
        public string Group { get; private set; } = string.Empty;

        [Column("esfera")]
        public string Realm { get; private set; } = string.Empty;

        [Column("cria_ano")]
        public string YearCreation { get; private set; } = string.Empty;

        [Column("cria_ato")]
        public string ActCreation { get; private set; } = string.Empty;

        [Column("cd_cnuc")]
        public string CNUCCode { get; private set; } = string.Empty;

        [Column("org_gestor")]
        public string ManagingBody { get; private set; } = string.Empty;

        protected ConservationUnit() { }
    }
}
