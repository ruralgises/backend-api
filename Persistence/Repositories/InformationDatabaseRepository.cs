using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Domain.Interfaces.Repositories;

namespace Persistence.Repositories
{
    public class InformationDatabaseRepository : IInformationDatabaseRepository
    {
        private readonly InformationDatabaseDbContext _context;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1); // Semáforo para sincronização

        public InformationDatabaseRepository(InformationDatabaseDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.InformationDatabase?> GetInfo(Domain.Enumerations.InformationDatabaseType entity, CancellationToken cancellationToken)
        {
            await _semaphore.WaitAsync(cancellationToken); // Aguarda até obter o semáforo
            try
            {
                return await _context
                    .informationDatabases
                    .Where(item => item.Entity == entity)
                    .FirstOrDefaultAsync(cancellationToken);
            }
            finally
            {
                _semaphore.Release(); // Libera o semáforo
            }
        }
    }

}
