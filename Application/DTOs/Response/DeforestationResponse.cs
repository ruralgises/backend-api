using Application.DTOs.Response.Bases;

namespace Application.DTOs.Response
{
    public class DeforestationResponse : GeoSpatialBaseIntersectionResponse
    {
        public int Year { get; init; }
    }
}
