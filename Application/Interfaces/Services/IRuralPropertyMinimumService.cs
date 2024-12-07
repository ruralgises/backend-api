using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.DTOs.Response.Bases;

namespace Application.Interfaces.Services
{
    public interface IRuralPropertyMinimumService
    {
        Task<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>> 
            GetByCode(GetByCodeRuralPropretiesMinimumRequest request, CancellationToken cancellationToken);
        Task<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>> 
            GetByGeometry(GetByGeometryRuralPropretiesMinimumRequest request, CancellationToken cancellationToken);
    }
}
