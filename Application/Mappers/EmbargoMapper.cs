using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class EmbargoMapper : BaseMapper<Embargo, EmbargoResponse>
    {
        public override EmbargoResponse ToResponse(Embargo embargo)
        {
            return new EmbargoResponse()
            {
                AdministrativeProcessNumber = embargo.AdministrativeProcessNumber,
                AreaIntersectHa = embargo.AreaIntersectHa,
                Article = embargo.Article,
                CPF_CNPJ = embargo.CPF_CNPJ,
                EmbargoIssuanceDate = embargo.EmbargoIssuanceDate,
                IdentificationEmbargoTerm = embargo.IdentificationEmbargoTerm,
                InflationActNumber = embargo.InflationActNumber,
                InfractionDescription = embargo.InfractionDescription,
                Legislation = embargo.Legislation,
                NameEmbargoed = embargo.NameEmbargoed,
                RegistrationDate = embargo.RegistrationDate,
                Status = embargo.Status,
                TotalEmbargoArea = embargo.TotalEmbargoArea,
                PercentageOfThePropertyArea = embargo.PercentageOfThePropertyArea
            };
        }
    }
}
