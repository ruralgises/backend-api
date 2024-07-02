using Application.DTOs.Response.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class SettlementResponse : GeoSpatialBaseIntersectionResponse
    {
        public string CodeSIPRA { get; init; } = string.Empty;
        public string NameProject { get; init; } = string.Empty;
        public int FamilyNumber { get; init; }
        public string CreationDate { get; init; } = string.Empty;
        public string WayObtaining { get; init; } = string.Empty;
        public string DateObtaining { get; init; } = string.Empty;
    }
}
