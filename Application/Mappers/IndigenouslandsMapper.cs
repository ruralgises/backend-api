using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class IndigenouslandsMapper : BaseMapper<Indigenouslands, IndigenouslandsResponse>
    {
        public override IndigenouslandsResponse ToResponse(Indigenouslands requisicao)
        {
            return new IndigenouslandsResponse()
            {
                LandCode = requisicao.LandCode,
                adminUnitAcronym = requisicao.adminUnitAcronym,
                adminUnitCode = requisicao.adminUnitCode,
                adminUnitName = requisicao.adminUnitName,
                AreaIntersectHa = requisicao.AreaIntersectHa,
                EthnicityName = requisicao.EthnicityName,
                IndigenousLandCreationPhase = requisicao.IndigenousLandCreationPhase,
                LandName = requisicao.LandName,
                Modality = requisicao.Modality,
                PercentageOfThePropertyArea = requisicao.PercentageOfThePropertyArea
            };
        }
    }
}
