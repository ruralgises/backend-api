using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class AlertMapper : BaseMapper<Alert, AlertResponse>
    {
        public override AlertResponse ToResponse(Alert requisicao)
        {
            return new AlertResponse()
            {
                AreaIntersectHa = requisicao.AreaIntersectHa,
                PercentageOfThePropertyArea = requisicao.PercentageOfThePropertyArea,
                CodeAlert = requisicao.CodeAlert,
                DetectDate = requisicao.DetectDate,
                Font = requisicao.Font,
                PublicationDate = requisicao.PublicationDate,
                VectorPressure = requisicao.VectorPressure,
                DetectYear = requisicao.DetectYear
            };
        }
    }
}
