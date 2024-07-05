using Application.DTOs.Response.Bases;
using Application.DTOs.Response;
using Application.Mappers;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using Domain.Enumerations;

namespace Application.Services
{
    public class EmbargoService : IEmbargoService
    {
        private IEmbargoesRepository _embargosRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        public EmbargoService(IEmbargoesRepository repository, IInformationDatabaseService informationDatabaseService)
        {
            this._embargosRepository = repository;
            this._informationDatabaseService = informationDatabaseService;
        }

        public async Task<GeoSpatialIntersectInformationResponse<EmbargoResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var embagoes = _embargosRepository.GetByGeometry(geom, cancellationToken);
            var embargoesResponse = EmbargoMapper.ToResponse(await embagoes);

            var informationResponse = await _informationDatabaseService.GetByNameAsync(Entity.Embargo, cancellationToken);

            return GeoSpatialIntersectInformationResponseMapper.ToInformationReponse(embargoesResponse, informationResponse);
        }
    }
}
