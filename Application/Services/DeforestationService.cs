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
    public class DeforestationService : IDeforestationService
    {
        private IDeforestationsRepository _deforestationRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }
        private BaseMapper<Deforestation, DeforestationResponse> Mapper { get; init; }

        public DeforestationService(IDeforestationsRepository repository, IInformationDatabaseService informationDatabaseService, BaseMapper<Deforestation, DeforestationResponse> mapper)
        {
            this._deforestationRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }
        public async Task<GeoSpatialIntersectInformationResponse<DeforestationResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var desforestationTask = _deforestationRepository.GetByGeometry(geom, cancellationToken);
            var informationResponse = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.Deforestation, cancellationToken);

            return GeoSpatialIntersectInformationResponseService.ToInformationReponse<Deforestation, DeforestationResponse>(Mapper, await desforestationTask, informationResponse);
        }
    }
}
