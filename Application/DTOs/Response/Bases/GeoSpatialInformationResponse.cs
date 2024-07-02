using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Bases
{
    public class GeoSpatialInformationResponse<T> where T : GeoSpatialBaseIntersectionResponse
    {
        public IList<T> Values { get; init; } = new List<T>();
        public double AreaIntersectTotalHa { get; init; }

        public InformationDatabaseResponse InformationDatabase {  get; init; }

        public GeoSpatialInformationResponse(InformationDatabaseResponse informationDatabase)
        {
            this.InformationDatabase = informationDatabase;
        }
    }
}
