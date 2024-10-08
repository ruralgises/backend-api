using Application.DTOs.Response;
using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IInformationDatabaseService
    {
        Task<InformationDatabaseResponse> GetByNameAsync(InformationDatabaseType entity, CancellationToken cancellationToken);
    }
}
