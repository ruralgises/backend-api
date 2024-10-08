using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class ConservationUnitService : IConservationUnitService
    {
        private IConservationUnitsRepository _conservationUnitRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        private BaseMapper<ConservationUnit, ConservationUnitResponse> Mapper { get; init; }

        public ConservationUnitService(IConservationUnitsRepository repository, IInformationDatabaseService informationDatabaseService, BaseMapper<ConservationUnit, ConservationUnitResponse> mapper)
        {
            this._conservationUnitRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<ConservationUnitResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var conservationUnitsTask = _conservationUnitRepository.GetByGeometry(geom, cancellationToken);

            var informationResponse = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.ConservationUnit, cancellationToken);

            var r = GeoSpatialIntersectInformationResponseService.ToInformationReponse<ConservationUnit, ConservationUnitResponse>(Mapper, await conservationUnitsTask, informationResponse);

            return r;
        }
    }
}
