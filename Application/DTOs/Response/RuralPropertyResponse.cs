using Application.DTOs.Response.Bases;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class RuralPropertyResponse
    {
        public string ThemeName { get; init; } = string.Empty;
        public string Code { get; init; } = string.Empty;
        public double AreaHa { get; init; }
        public string Status { get; init; } = string.Empty;
        public string Type { get; init; } = string.Empty;
        public string Condition { get; init; } = string.Empty;
        public LocationResponse? Location { get; set; }
        public GeoSpatialInformationResponse<ConservationUnitResponse>? ConservationUnits { get; set; }
        public GeoSpatialInformationResponse<DeforestationResponse>? Deforestations { get; set; }
        public GeoSpatialInformationResponse<EmbargoResponse>? Embargoes { get; set; }
        public GeoSpatialInformationResponse<QuilombolaAreaResponse>? QuilombolaAreas { get; set; }
        public GeoSpatialInformationResponse<SettlementResponse>? Settlements { get; set; }
    }
}
