using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
