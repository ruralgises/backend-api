using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class InformationDatabaseResponse
    {
        public string DatabaseName { get; set; } = string.Empty;
        public DateOnly LastUpdate { get; set; }

        public bool IsOfficial { get; set; }
    }
}
