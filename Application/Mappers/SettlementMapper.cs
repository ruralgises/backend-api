using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class SettlementMapper
    {
        public static SettlementResponse ToResponse(Settlement settlement)
        {
            return new SettlementResponse()
            {
                AreaIntersectHa = settlement.AreaIntersectHa,
                AreaTotalHa = settlement.AreaTotalHa,
                CodeSIPRA = settlement.CodeSIPRA,
                CreationDate = settlement.CreationDate,
                DateObtaining = settlement.DateObtaining,
                FamilyNumber = settlement.FamilyNumber,
                NameProject = settlement.NameProject,
                WayObtaining = settlement.WayObtaining
            };
        }

        public static IList<SettlementResponse> ToResponse(IList<Settlement> settlements)
        {
            var response = new List<SettlementResponse>();

            foreach (var item in settlements) { 
                response.Add(ToResponse(item));
            }

            return response;
        }
    }
}
