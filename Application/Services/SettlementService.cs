using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class SettlementService : ISettlementService
    {
        private ISettlementsRepository _settlementRepository {  get; init; }

        private IInformationDatabaseService _informationDatabaseService { get; init; }
        private BaseMapper<Settlement, SettlementResponse> Mapper { get; init; }

        public SettlementService(ISettlementsRepository settlementService, IInformationDatabaseService informationDatabaseService, BaseMapper<Settlement, SettlementResponse> mapper)
        {
            _settlementRepository = settlementService;
            _informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<SettlementResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var settlementTask = _settlementRepository.GetByGeometry(geom, cancellationToken);

            var information = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.Settlement, cancellationToken);

            return GeoSpatialIntersectInformationResponseService.ToInformationReponse< Settlement, SettlementResponse>(Mapper, await settlementTask, information);
        }
    }
}
