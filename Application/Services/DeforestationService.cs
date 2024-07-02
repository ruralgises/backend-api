using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DeforestationService : IDeforestationService
    {
        private IDeforestationsRepository _deforestationRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        public DeforestationService(IDeforestationsRepository repository, IInformationDatabaseService informationDatabaseService)
        {
            this._deforestationRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
        }
        public async Task<GeoSpatialInformationResponse<DeforestationResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var desforestation = _deforestationRepository.GetByGeometry(geom, cancellationToken);
            var desforestationResponse = DeforestationMapper.ToReponse(await desforestation);

            var informationResponse = await _informationDatabaseService.GetByNameAsync("Deforestation", cancellationToken);

            return GeoSpatialInformationResponseMapper.ToInformationReponse(desforestationResponse, informationResponse);
        }
    }
}
