using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class LocationResponse
    {
        public MunicipalityResponse? MunicipalityResponse { get; init; }
        public MicroregionResponse? MicroregionResponse { get; init; }
        public MessoregionResponse? MessoregionResponse { get; init; }

        public InformationDatabaseResponse InformationDatabase { get; init; }

        public LocationResponse(MunicipalityResponse municipality, MicroregionResponse microregion, MessoregionResponse messoregion, InformationDatabaseResponse informationDatabase)
        {
            this.MunicipalityResponse = municipality;
            this.MicroregionResponse = microregion;
            this.MessoregionResponse = messoregion;
            this.InformationDatabase = informationDatabase;
        }
    }
}
