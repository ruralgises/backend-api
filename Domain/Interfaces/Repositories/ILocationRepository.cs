namespace Domain.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Task<Domain.Entities.Location> GetByMunipalityName(string MunicipalyName, CancellationToken cancellationToken);
    }
}
