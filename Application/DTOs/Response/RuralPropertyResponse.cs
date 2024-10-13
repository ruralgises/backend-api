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
        public InformationDatabaseResponse InformationDatabase { get; set; }
        public LocationResponse? Location { get; set; }
        public GeoSpatialIntersectInformationResponse<ConservationUnitResponse>? ConservationUnits { get; set; }
        public GeoSpatialIntersectInformationResponse<DeforestationResponse>? Deforestations { get; set; }
        public GeoSpatialIntersectInformationResponse<EmbargoResponse>? Embargoes { get; set; }
        public GeoSpatialIntersectInformationResponse<QuilombolaAreaResponse>? QuilombolaAreas { get; set; }
        public GeoSpatialIntersectInformationResponse<SettlementResponse>? Settlements { get; set; }
        public GeoSpatialIntersectInformationResponse<UseCoverageResponse>? UseCoverage { get; set; }
        public GeoSpatialIntersectInformationResponse<AlertResponse>? Alert { get; set; }
        public GeoSpatialIntersectInformationResponse<IndigenouslandsResponse>? Indigenousland { get; set; }
    }
}
