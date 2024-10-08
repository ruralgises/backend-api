using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class SettlementMapper : BaseMapper<Settlement, SettlementResponse>
    {
        public override SettlementResponse ToResponse(Settlement settlement)
        {
            return new SettlementResponse()
            {
                AreaIntersectHa = settlement.AreaIntersectHa,
                CodeSIPRA = settlement.CodeSIPRA,
                CreationDate = settlement.CreationDate,
                DateObtaining = settlement.DateObtaining,
                FamilyNumber = settlement.FamilyNumber,
                NameProject = settlement.NameProject,
                WayObtaining = settlement.WayObtaining,
                PercentageOfThePropertyArea = settlement.PercentageOfThePropertyArea
            };
        }
    }
}
