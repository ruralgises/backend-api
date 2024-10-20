using Application.DTOs.Response.Bases;

namespace Application.DTOs.Response
{
    public class IndigenouslandsResponse : GeoSpatialBaseIntersectionResponse
    {
        public int LandCode { get; set; }
        public string LandName { get; init; }
        public string EthnicityName { get; init; }
        public string IndigenousLandCreationPhase { get; init; }
        public string Modality { get; init; }
        public string adminUnitCode { get; init; }
        public string adminUnitName { get; init; }
        public string adminUnitAcronym { get; init; }
    }
}
