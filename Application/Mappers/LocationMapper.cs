using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public static class LocationMapper
    {
        public static LocationResponse? ToResponse(Location location, InformationDatabaseResponse informationDatabase)
        {
            if (location == null) return null;

            return new LocationResponse(
                MunicipalityMapper.ToResponse(location.Municipality),
                MicroregionMapper.ToResponse(location.Microregion),
                MessoregionMapper.ToResponse(location.Messorerion),
                informationDatabase)
            {};
        }
    }
}
