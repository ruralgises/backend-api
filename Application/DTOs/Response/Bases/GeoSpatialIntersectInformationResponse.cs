using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Bases
{
    public class GeoSpatialIntersectInformationResponse<T> : GeoSpatialInformationResponse<T> where T : GeoSpatialBaseIntersectionResponse
    {
        public GeoSpatialIntersectInformationResponse(
            IList<T> values, 
            InformationDatabaseResponse informationDatabase, 
            double areaIntersectTotalHa,
            double percentageOfThePropertyArea
        ) 
            : base(values, informationDatabase)
        {
            AreaIntersectTotalHa = areaIntersectTotalHa;
            PercentageOfThePropertyArea = percentageOfThePropertyArea;
        }

        public double AreaIntersectTotalHa { get; init; }
        public double PercentageOfThePropertyArea { get; init; }

    }
}
