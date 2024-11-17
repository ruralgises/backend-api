using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Persistence.Repositories
{
    public class LocationsRepository : ILocationsRepository
    {
        private readonly IMunicipalitiesRepository _municipalityRepository;
        private readonly IMicroregionRepository _microregionRepository;
        private readonly IMessoreionRepository _messoreionRepository;

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1); // Semáforo para sincronização

        public LocationsRepository(
            IMunicipalitiesRepository municipalityRepository, 
            IMicroregionRepository microregionRepository, 
            IMessoreionRepository messoreionRepository
        ){
            _messoreionRepository = messoreionRepository;
            _microregionRepository = microregionRepository;
            _municipalityRepository = municipalityRepository;
        }

        public async Task<Location> GetByMunipalityName(string MunicipalyName, CancellationToken cancellationToken)
        {
            await _semaphore.WaitAsync(cancellationToken); // Aguarda até obter o semáforo
            try
            {
                var municipality = await _municipalityRepository.GetByName(MunicipalyName, cancellationToken);
                var microregion = await _microregionRepository.GetByGeometry(municipality.Geom, cancellationToken);
                var mesoregion = await _messoreionRepository.GetByGeometry(municipality.Geom, cancellationToken);

                return new Location
                {
                    Messorerion = mesoregion,
                    Microregion = microregion,
                    Municipality = municipality
                };
            }
            finally
            {
                _semaphore.Release(); // Libera o semáforo
            }
        }
    }
}
