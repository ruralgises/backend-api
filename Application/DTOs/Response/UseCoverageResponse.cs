using Application.DTOs.Response.Bases;

namespace Application.DTOs.Response
{
    public class UseCoverageResponse : GeoSpatialBaseIntersectionResponse
    {
        public int Class { get; set; }
        public string Name { get; set; }
    }
}
