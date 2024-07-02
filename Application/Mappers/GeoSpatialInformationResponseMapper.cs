using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class GeoSpatialInformationResponseMapper
    {
        public static GeoSpatialInformationResponse<T> ToInformationReponse<T>(IList<T> intersectionResponses, InformationDatabaseResponse informationDatabaseResponse) where T : GeoSpatialBaseIntersectionResponse
        {
            return new GeoSpatialInformationResponse<T>(informationDatabaseResponse)
            {
                Values = intersectionResponses,
                AreaIntersectTotalHa = intersectionResponses.Select(x => x.AreaIntersectHa).Sum()
            };
        }
            
    }
}
