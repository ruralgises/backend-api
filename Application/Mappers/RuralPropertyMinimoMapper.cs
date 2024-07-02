using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class RuralPropertyMinimoMapper
    {
        public static RuralPropertyMinimumResponse ToResponse(RuralProperty ruralPropertie)
        {
            return new RuralPropertyMinimumResponse
            {
                ThemeName = ruralPropertie.ThemeName,
                Code = ruralPropertie.Code,
                AreaHa = ruralPropertie.AreaHa,
                Status = ruralPropertie.Status,
                Type = ruralPropertie.Type,
                Condition = ruralPropertie.Condition,
                Municipio = ruralPropertie.Municipio
            };
        }

        public static IList<RuralPropertyMinimumResponse> ToResponse(IList<RuralProperty> ruralProperties)
        {
            var responses = new List<RuralPropertyMinimumResponse>();

            foreach (var item in ruralProperties)
            {
                responses.Add(ToResponse(item));
            }

            return responses;
        }
    }
}
