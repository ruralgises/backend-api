using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.CompletedRuralProperty.bases;
using Application.Interfaces.Services;
using Application.Interfaces.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.CompletedRuralProperty
{
    public class ConservationUnitHandler : CompletedRuralPropertyHandlerIntersectionBaseImp<ConservationUnitResponse>
    {
        public ConservationUnitHandler(IConservationUnitService conservationUnitService) : base(conservationUnitService)
        {
        }

        public override void Assign(RuralPropertyResponse ruralPropertyResponse, GeoSpatialIntersectInformationResponse<ConservationUnitResponse> intersectionResponse)
        {
            ruralPropertyResponse.ConservationUnits = intersectionResponse;
        }
    }
}
