using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class MessoregionMapper
    {
        public static DTOs.Response.MessoregionResponse ToResponse(Domain.Entities.Messoregion messoregion)
        {
            return new DTOs.Response.MessoregionResponse()
            {
                Code = messoregion.Code,
                Name = messoregion.Name
            };
        }
    }
}
