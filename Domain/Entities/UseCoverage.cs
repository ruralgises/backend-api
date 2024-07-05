using Domain.Entities.BasesEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("uso_cobertura")]
    public class UseCoverage : GeoSpatialBaseIntersection
    {
        [Column("class")]
        public int Class { get; set; }

        [Column("class_name")]
        public string Name { get; set; }
    }
}
