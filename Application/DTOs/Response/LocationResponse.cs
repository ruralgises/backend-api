namespace Application.DTOs.Response
{
    public class LocationResponse
    {
        public MunicipalityResponse? Municipality { get; init; }
        public MicroregionResponse? Microregion { get; init; }
        public MessoregionResponse? Messoregion { get; init; }

        public InformationDatabaseResponse InformationDatabase { get; init; }

        public LocationResponse(MunicipalityResponse municipality, MicroregionResponse microregion, MessoregionResponse messoregion, InformationDatabaseResponse informationDatabase)
        {
            this.Municipality = municipality;
            this.Microregion = microregion;
            this.Messoregion = messoregion;
            this.InformationDatabase = informationDatabase;
        }
    }
}
