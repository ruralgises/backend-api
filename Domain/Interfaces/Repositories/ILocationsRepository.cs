namespace Domain.Interfaces.Repositories
{
    public interface ILocationsRepository
    {
        Task<Domain.Entities.Location> GetByMunipalityName(string MunicipalyName, CancellationToken cancellationToken);
    }
}
