using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class RuralPropertyMinimumService : IRuralPropertyMinimumService
    {
        private IRuralPropertiesRepository _Repository { get; init; }

        public RuralPropertyMinimumService(IRuralPropertiesRepository repository)
        {
            _Repository = repository;
        }

        public async Task<IList<RuralPropertyMinimumResponse>> GetByCode(GetByCodeRuralPropretiesMinimumRequest request, CancellationToken cancellationToken)
        {
            var r = await _Repository.GetByCode(request.Code, request.Skip, request.Take, cancellationToken);

            return RuralPropertyMinimoMapper.ToResponse(r);
        }

        public async Task<IList<RuralPropertyMinimumResponse>> GetByCoordinate(GetByCoordinateRuralPropretiesMinimumRequest request, CancellationToken cancellationToken)
        {
            var r = await _Repository.GetByCoordinate(request.Coordinate, request.Skip, request.Take, cancellationToken);

            return RuralPropertyMinimoMapper.ToResponse(r);
        }
    }
}
