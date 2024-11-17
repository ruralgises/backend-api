using Domain.Entities;
using Domain.Enumerations;

namespace Domain.Interfaces.Repositories
{
    public interface IInformationDatabaseRepository
    {
        Task<InformationDatabase?> GetInfo(InformationDatabaseType entity, CancellationToken cancellationToken);
    }
}
