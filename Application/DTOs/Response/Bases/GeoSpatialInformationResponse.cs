using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Bases
{
    public class GeoSpatialInformationResponse<T>
    {
        public IList<T> Values { get; init; } = new List<T>();

        public InformationDatabaseResponse InformationDatabase { get; init; }

        public GeoSpatialInformationResponse(IList<T> values, InformationDatabaseResponse informationDatabase)
        {
            Values = values;
            InformationDatabase = informationDatabase;
        }
    }
}
