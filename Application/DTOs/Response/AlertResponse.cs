using Application.DTOs.Response.Bases;

namespace Application.DTOs.Response
{
    public class AlertResponse : GeoSpatialBaseIntersectionResponse
    {
        public int CodeAlert { get; init; }
        public int DetectYear { get; init; }
        public DateOnly DetectDate { get; init; }
        public DateOnly PublicationDate { get; init; }
        public string VectorPressure { get; init; }
        public string Font { get; init; }
    }
}
