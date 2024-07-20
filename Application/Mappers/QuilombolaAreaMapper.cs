using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class QuilombolaAreaMapper : BaseMapper<QuilombolaArea, QuilombolaAreaResponse>
    {
        public override QuilombolaAreaResponse ToResponse(QuilombolaArea quilombolaArea)
        {
            return new QuilombolaAreaResponse()
            {
                AreaIntersectHa = quilombolaArea.AreaIntersectHa,
                CommunityName = quilombolaArea.CommunityName,
                DecreeDate = quilombolaArea.DecreeDate,
                FamilyNumber = quilombolaArea.FamilyNumber,
                Phase = quilombolaArea.Phase,
                ProcessNumber = quilombolaArea.ProcessNumber,
                Realm = quilombolaArea.Realm,
                Responsible = quilombolaArea.Responsible,
            };
        }
    }
}
