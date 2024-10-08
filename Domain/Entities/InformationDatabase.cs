using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InformationDatabase
    {
        [Key]
        public Enumerations.InformationDatabaseType Entity { get; set; }
        public string DatabaseName { get; set; } = string.Empty;
        public DateOnly LastUpdate { get; set; }
        public bool IsOfficial { get; set; }
    }
}
