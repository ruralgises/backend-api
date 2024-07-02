using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class ConservationUnitService : IConservationUnitService
    {
        private IConservationUnitsRepository _conservationUnitRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        public ConservationUnitService(IConservationUnitsRepository repository, IInformationDatabaseService informationDatabaseService)
        {
            this._conservationUnitRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
        }

        public async Task<GeoSpatialInformationResponse<ConservationUnitResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var conservationUnits = _conservationUnitRepository.GetByGeometry(geom, cancellationToken);
            var conservationUnitsResponse = ConservationUnitMapper.ToResponse(await conservationUnits);

            var informationResponse = await _informationDatabaseService.GetByNameAsync("ConservationUnit", cancellationToken);

            var r = GeoSpatialInformationResponseMapper.ToInformationReponse<ConservationUnitResponse>(conservationUnitsResponse, informationResponse);

            return r;
        }
    }
}
