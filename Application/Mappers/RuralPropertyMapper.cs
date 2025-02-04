using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class RuralPropertyMapper
    {
        public static RuralPropertyResponse ToResponse(RuralProperty ruralPropertie)
        {
            return new RuralPropertyResponse
            {
                ThemeName = ruralPropertie.ThemeName,
                Code = ruralPropertie.Code,
                AreaHa = ruralPropertie.AreaHa ?? 0,
                Status = ruralPropertie.Status,
                Type = ruralPropertie.Type,
                Condition = ruralPropertie.Condition
            };
        }

        public static IList<RuralPropertyResponse> ToResponse (IList<RuralProperty> ruralProperties) {
           var responses = new List<RuralPropertyResponse>();

            foreach (var item in ruralProperties)
            {
                responses.Add (ToResponse(item));
            }

            return responses;
        }
    }
}
