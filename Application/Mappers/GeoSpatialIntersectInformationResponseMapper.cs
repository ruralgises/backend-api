using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Domain.Entities.BasesEntities;

namespace Application.Mappers
{
    public static class GeoSpatialIntersectInformationResponseMapper
    {
        public static GeoSpatialIntersectInformationResponse<T> ToInformationReponse<T>(IList<T> intersectionResponses, InformationDatabaseResponse informationDatabaseResponse) where T : GeoSpatialBaseIntersectionResponse
        {
            return new GeoSpatialIntersectInformationResponse<T>(intersectionResponses, informationDatabaseResponse, intersectionResponses.Select(x => x.AreaIntersectHa).Sum());
        }

        public static GeoSpatialIntersectInformationResponse<Rp> ToInformationReponse<Rq, Rp>
            (BaseMapper<Rq, Rp> baseMapper, IList<Rq> intersection, InformationDatabaseResponse informationDatabaseResponse)
        where Rq : GeoSpatialBaseIntersection
        where Rp : GeoSpatialBaseIntersectionResponse
        {
            var intersectionResponses = baseMapper.ToResponses(intersection);
            return ToInformationReponse(intersectionResponses, informationDatabaseResponse);
        }
    }
}
