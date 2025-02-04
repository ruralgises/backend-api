using Application.DTOs.Response;
using Domain.Entities;

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
                AreaHa = ruralPropertie.AreaHa ?? 0,
                Status = ruralPropertie.Status,
                Type = ruralPropertie.Type,
                Condition = ruralPropertie.Condition,
                Municipio = ruralPropertie.Municipio,
                Geom = ruralPropertie.Geom,
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
