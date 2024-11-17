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
        public static DTOs.Response.MunicipalityResponse ToResponse(Domain.Entities.Municipality municipality)
        {
            return new DTOs.Response.MunicipalityResponse()
            {
                Code = municipality.Code,
                Name = municipality.Name
            };
        }
    }
}
