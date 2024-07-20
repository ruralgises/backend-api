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
    public class EmbargoService : IEmbargoService
    {
        private IEmbargoesRepository _embargosRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        private BaseMapper<Embargo, EmbargoResponse> Mapper { get; init; }

        public EmbargoService(BaseMapper<Embargo, EmbargoResponse> mapper, IEmbargoesRepository repository, IInformationDatabaseService informationDatabaseService)
        {
            this._embargosRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<EmbargoResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var embagoesTask = _embargosRepository.GetByGeometry(geom, cancellationToken);

            var informationResponse = await _informationDatabaseService.GetByNameAsync(Entity.Embargo, cancellationToken);

            return GeoSpatialIntersectInformationResponseMapper.ToInformationReponse<Embargo, EmbargoResponse>(Mapper, await embagoesTask, informationResponse);
        }
    }
}
