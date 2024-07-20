using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class ConservationUnitMapper : BaseMapper<ConservationUnit, ConservationUnitResponse>
    {
        public override ConservationUnitResponse ToResponse(ConservationUnit conservationUnit)
        {
            return new ConservationUnitResponse()
            {
                UCName = conservationUnit.UCName,
                Category = conservationUnit.Category,
                ActCreation = conservationUnit.ActCreation,
                AreaIntersectHa = conservationUnit.AreaIntersectHa,
                CNUCCode = conservationUnit.CNUCCode,
                Group = conservationUnit.Group,
                Realm = conservationUnit.Realm,
                ManagingBody = conservationUnit.ManagingBody,
                YearCreation = conservationUnit.YearCreation
            };
        }
    }
}
