using Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IInformationDatabaseService
    {
        Task<InformationDatabaseResponse> GetByNameAsync(string name, CancellationToken cancellationToken);
    }
}
