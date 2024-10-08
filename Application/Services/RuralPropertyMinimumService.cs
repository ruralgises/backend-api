using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class RuralPropertyMinimumService : IRuralPropertyMinimumService
    {
        private IRuralPropertiesRepository _Repository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; set; }

        public RuralPropertyMinimumService(IRuralPropertiesRepository repository, IInformationDatabaseService informationDatabaseService)
        {
            _Repository = repository;
            _informationDatabaseService = informationDatabaseService;
        }

        public async Task<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>> GetByCode(GetByCodeRuralPropretiesMinimumRequest request, CancellationToken cancellationToken)
        {
            var r = await _Repository.GetByCode(request.Code, request.Skip, request.Take, cancellationToken);
            var information = _informationDatabaseService.GetByNameAsync(InformationDatabaseType.RuralProperty, cancellationToken);

            return new GeoSpatialInformationResponse<RuralPropertyMinimumResponse>(RuralPropertyMinimoMapper.ToResponse(r), await information);
        }

        public async Task<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>> GetByCoordinate(GetByCoordinateRuralPropretiesMinimumRequest request, CancellationToken cancellationToken)
        {
            var r = await _Repository.GetByCoordinate(request.Coordinate, request.Skip, request.Take, cancellationToken);
            var information = _informationDatabaseService.GetByNameAsync(InformationDatabaseType.RuralProperty, cancellationToken);

            return new GeoSpatialInformationResponse<RuralPropertyMinimumResponse>(RuralPropertyMinimoMapper.ToResponse(r), await information);
        }
    }
}
