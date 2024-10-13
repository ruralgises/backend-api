using Application.DTOs.Request;
using Application.DTOs.Response;

namespace Application.Interfaces.Services
{
    public interface IRuralPropertyService
    {
        Task<RuralPropertyResponse?> GetByCode(GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken);
    }
}
