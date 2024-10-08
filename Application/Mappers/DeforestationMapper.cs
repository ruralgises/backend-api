using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class DeforestationMapper : BaseMapper<Deforestation, DeforestationResponse>
    {
        public override DeforestationResponse ToResponse(Deforestation deforestation)
        {
            return new DeforestationResponse()
            {
                AreaIntersectHa = deforestation.AreaIntersectHa,
                Year = deforestation.Year,
                PercentageOfThePropertyArea = deforestation.PercentageOfThePropertyArea
            };
        }
    }
}
