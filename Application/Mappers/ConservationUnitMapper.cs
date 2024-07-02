using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Mappers
{
    public static class ConservationUnitMapper
    {
        public static ConservationUnitResponse ToResponse(ConservationUnit conservationUnit)
        {
            return new ConservationUnitResponse()
            {
                UCName = conservationUnit.UCName,
                Category = conservationUnit.Category,
                ActCreation = conservationUnit.ActCreation,
                AreaIntersectHa = conservationUnit.AreaIntersectHa,
                AreaTotalHa = conservationUnit.AreaTotalHa,
                CNUCCode = conservationUnit.CNUCCode,
                Group = conservationUnit.Group,
                Realm = conservationUnit.Realm,
                ManagingBody = conservationUnit.ManagingBody,
                YearCreation = conservationUnit.YearCreation
            };
        }

        public static IList<ConservationUnitResponse> ToResponse(IList<ConservationUnit> conservationUnits) { 
            var response = new List<ConservationUnitResponse>();

            foreach (var item in conservationUnits)
            {
                response.Add(ToResponse(item));
            }

            return response;
        }

    }
}
