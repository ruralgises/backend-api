using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class DeforestationMapper : BaseMapper<Deforestation, DeforestationResponse>
    {
        public override DeforestationResponse ToResponse(Deforestation deforestatio)
        {
            return new DeforestationResponse()
            {
                AreaIntersectHa = deforestatio.AreaIntersectHa,
                Year = deforestatio.Year
            };
        }
    }
}
