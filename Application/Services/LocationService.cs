using Application.DTOs.Response;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class LocationService : ILocationService
    {
        private ILocationRepository _locationsRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService;

        public LocationService(ILocationRepository locationsRepository, IInformationDatabaseService informationDatabaseService)
        {
            _locationsRepository = locationsRepository;
            _informationDatabaseService = informationDatabaseService;
        }

        public async Task<LocationResponse> GetByMunipalityName(string MunicipalyName, CancellationToken cancellationToken)
        {
            var locationTask = _locationsRepository.GetByMunipalityName(MunicipalyName, cancellationToken);
            var informationTask = _informationDatabaseService.GetByNameAsync(InformationDatabaseType.Location, cancellationToken);

            return LocationMapper.ToResponse(await locationTask, await informationTask);
        }
    }
}
