using Application.DTOs.Response.Bases;

namespace Application.DTOs.Response
{
    public class ConservationUnitResponse : GeoSpatialBaseIntersectionResponse
    {
        public string UCName { get; init; } = string.Empty;
        public string Category { get; init; } = string.Empty;
        public string Group { get; init; } = string.Empty;
        public string Realm { get; init; } = string.Empty;
        public string YearCreation { get; init; } = string.Empty;
        public string ActCreation { get; init; } = string.Empty;
        public string CNUCCode { get; init; } = string.Empty;
        public string ManagingBody { get; init; } = string.Empty;
    }
}
