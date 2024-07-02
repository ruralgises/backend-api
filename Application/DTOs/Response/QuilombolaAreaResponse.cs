using Application.DTOs.Response.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class QuilombolaAreaResponse : GeoSpatialBaseIntersectionResponse
    {
        public string ProcessNumber { get; init; } = string.Empty;
        public string CommunityName { get; init; } = string.Empty;
        public int FamilyNumber { get; init; }
        public string DecreeDate { get; init; } = string.Empty;
        public string Realm { get; init; } = string.Empty;
        public string Phase { get; init; } = string.Empty;
        public string Responsible { get; init; } = string.Empty;
    }
}
