using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class DeforestationMapper
    {
        public static DeforestationResponse ToReponse(Deforestation deforestatio)
        {
            return new DeforestationResponse()
            {
                AreaIntersectHa = deforestatio.AreaIntersectHa,
                AreaTotalHa = deforestatio.AreaTotalHa,
                Year = deforestatio.Year
            };
        }

        public static IList<DeforestationResponse> ToReponse(IList<Deforestation> deforestations)
        {
            var response = new List<DeforestationResponse>();

            foreach (var item in deforestations)
            {
                response.Add(ToReponse(item));
            }

            return response;
        }
    }
}
