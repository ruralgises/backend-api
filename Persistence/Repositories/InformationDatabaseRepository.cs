using Domain.Entities;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<InformationDatabase?> GetInfo(Entity entity, CancellationToken cancellationToken)
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
