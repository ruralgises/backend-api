using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services.Bases;
using Domain.Entities;

namespace Application.Interfaces.CompletedRuralProperty.bases
{
    public abstract class CompletedRuralPropertyHandlerIntersectionBaseImp<T> : CompletedRuralPropertyHandler where T : GeoSpatialBaseIntersectionResponse
    {
        private IGeoSpatialBaseService<T> _Service { get; set; }

        public CompletedRuralPropertyHandlerIntersectionBaseImp(IGeoSpatialBaseService<T> conservationUnitService)
        {
            _Service = conservationUnitService;
        }

        public async override Task Handler(RuralPropertyResponse ruralPropertyResponse, RuralProperty ruralProperty, CancellationToken cancellationToken)
        {
            var taskConservationUnit = _Service.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var taskNext = _Next?.Handler(ruralPropertyResponse, ruralProperty, cancellationToken);

            Assign(ruralPropertyResponse, await taskConservationUnit);

            //garante que ao esperar esse método ser concluído, também esperar o método seguinte ser concluído
            await taskNext;
        }

        public abstract void Assign(RuralPropertyResponse ruralPropertyResponse, GeoSpatialInformationResponse<T> intersectionResponse);
    }
}
