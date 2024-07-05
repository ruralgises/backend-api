using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class EmbargoMapper
    {
        public static EmbargoResponse ToResponse(Embargo embargo)
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
                TotalEmbargoArea = embargo.TotalEmbargoArea
            };
        }

        public static IList<EmbargoResponse> ToResponse(IList<Embargo> embargoes)
        {
            var response = new List<EmbargoResponse>();

            foreach (var item in embargoes)
            {
                response.Add(ToResponse(item));
            }

            return response;
        }
    }
}
