using Application.DTOs.Request;
using Application.DTOs.Response;

namespace Application.Interfaces.Services
{
    public interface IRuralPropertyMinimumService
    {
        Task<IList<RuralPropertyMinimumResponse>> GetByCode(GetByCodeRuralPropretiesMinimumRequest request, CancellationToken cancellationToken);
        Task<IList<RuralPropertyMinimumResponse>> GetByCoordinate(GetByCoordinateRuralPropretiesMinimumRequest request, CancellationToken cancellationToken);
    }
}
