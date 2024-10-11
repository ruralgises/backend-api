using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class RuralPropertyService : IRuralPropertyService
    {
        private IRuralPropertiesRepository _Repository {  get; init; }
        private ILocationService _LocationService { get; init; }
        private IConservationUnitService _ConservationUnitService { get; init; }
        private IDeforestationService _DeforestationService { get; init; }
        private IEmbargoService _EmbargoService { get; init; }
        private IQuilombolaAreaService _QuilombolaAreaService { get; init; }
        private ISettlementService _SettlementService { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; set; }
        private IUseCoverageService _useCoverageService { get; set; }
        private IAlertService _alertService { get; set; }

        public RuralPropertyService(
            IRuralPropertiesRepository ruralPropertiesRepository,
            ILocationService locationService,
            IConservationUnitService conservationUnitService,
            IDeforestationService deforestationService,
            IEmbargoService embargoService,
            IQuilombolaAreaService quilombolaAreaService,
            ISettlementService settlementService,
            IInformationDatabaseService informationDatabaseService,
            IUseCoverageService useCoverageService,
            IAlertService alertService)
        {
            _Repository = ruralPropertiesRepository;
            _LocationService = locationService;
            _ConservationUnitService = conservationUnitService;
            _DeforestationService = deforestationService;
            _EmbargoService = embargoService;
            _QuilombolaAreaService = quilombolaAreaService;
            _SettlementService = settlementService;
            _informationDatabaseService = informationDatabaseService;
            _useCoverageService = useCoverageService;
            _alertService = alertService;
        }

        public async Task<RuralPropertyResponse> GetByCode(GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken = default)
        {
            var ruralProperties =  await _Repository.GetByCode(request.Code, cancellationToken);

            return await CompletedRuralProperty(ruralProperties, cancellationToken);
        }

        private async Task<RuralPropertyResponse> CompletedRuralProperty(RuralProperty ruralProperty, CancellationToken cancellationToken = default)
        {
            //obtain missing data
            var locationTask = _LocationService.GetByMunipalityName(ruralProperty.Municipio, cancellationToken);
            var conservationUnitTask = _ConservationUnitService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var deforestationTask = _DeforestationService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var embargoTask = _EmbargoService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var quilombolaAreaTask = _QuilombolaAreaService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var settlementTask = _SettlementService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var useCoverageTask = _useCoverageService.GetByGeometry(ruralProperty.Geom, cancellationToken);
            var alertTask = _alertService.GetByGeometry(ruralProperty.Geom, cancellationToken);

            //create RuralPropertyResponse
            var ruralPropertyResponse = RuralPropertyMapper.ToResponse(ruralProperty);
            ruralPropertyResponse.InformationDatabase = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.RuralProperty, cancellationToken);

            //assigning missing data
            ruralPropertyResponse.Location = await locationTask;
            ruralPropertyResponse.ConservationUnits = await conservationUnitTask;
            ruralPropertyResponse.Deforestations = await deforestationTask;
            ruralPropertyResponse.Embargoes = await embargoTask;
            ruralPropertyResponse.QuilombolaAreas = await quilombolaAreaTask;
            ruralPropertyResponse.Settlements = await settlementTask;
            ruralPropertyResponse.UseCoverage = await useCoverageTask;
            ruralPropertyResponse.Alert = await alertTask;

            return ruralPropertyResponse;
        }
    }
}
