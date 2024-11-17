using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class MicroregionMapper
    {
        public static DTOs.Response.MicroregionResponse ToResponse(Domain.Entities.Microregion microregion)
        {
            return new DTOs.Response.MicroregionResponse()
            {
                Code = microregion.Code,
                Name = microregion.Name
            };
        }
    }
}
