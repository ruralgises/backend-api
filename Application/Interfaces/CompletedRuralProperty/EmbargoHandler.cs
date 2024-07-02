using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.CompletedRuralProperty.bases;
using Application.Interfaces.Services;

namespace Application.Interfaces.CompletedRuralProperty
{
    public class EmbargoHandler : CompletedRuralPropertyHandlerIntersectionBaseImp<EmbargoResponse>
    {
        public EmbargoHandler(IEmbargoService conservationUnitService) : base(conservationUnitService)
        {
        }

        public override void Assign(RuralPropertyResponse ruralPropertyResponse, GeoSpatialInformationResponse<EmbargoResponse> intersectionResponse)
        {
            ruralPropertyResponse.Embargoes = intersectionResponse;
        }
    }
}
