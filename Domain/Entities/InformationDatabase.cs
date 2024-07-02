using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InformationDatabase
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public DateOnly LastUpdate { get; set; }
        public bool IsOfficial { get; set; }
    }
}
