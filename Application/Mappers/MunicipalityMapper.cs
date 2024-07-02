using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class MunicipalityMapper
    {
        public static MunicipalityResponse ToResponse(Municipality municipality)
        {
            return new MunicipalityResponse()
            {
                Code = municipality.Code,
                Name = municipality.Name
            };
        }
    }
}
