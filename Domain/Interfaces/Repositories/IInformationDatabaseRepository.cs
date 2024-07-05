using Domain.Entities;
using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IInformationDatabaseRepository
    {
         Task<InformationDatabase?> GetInfo(Entity entity, CancellationToken cancellationToken);
    }
}
