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
    public class SettlementService : ISettlementService
    {
        private ISettlementsRepository _settlementRepository {  get; init; }

        private IInformationDatabaseService _informationDatabaseService { get; init; }

        public SettlementService(ISettlementsRepository settlementService, IInformationDatabaseService informationDatabaseService)
        {
            _settlementRepository = settlementService;
            _informationDatabaseService = informationDatabaseService;
        }

        public async Task<GeoSpatialInformationResponse<SettlementResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var settlement = _settlementRepository.GetByGeometry(geom, cancellationToken);
            var settlementResponse = SettlementMapper.ToResponse(await settlement);

            var information = _informationDatabaseService.GetByNameAsync("Settlement", cancellationToken);

            return GeoSpatialInformationResponseMapper.ToInformationReponse(settlementResponse, await information);
        }
    }
}
