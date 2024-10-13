using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class IndigenouslandsService : IIndigenouslandsService
    {
        private IIndigenouslandsRepository _indigenouslandsRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }
        private BaseMapper<Indigenouslands, IndigenouslandsResponse> _baseMapper { get; init; }

        public IndigenouslandsService(
            IIndigenouslandsRepository indigenouslandsRepository,
            IInformationDatabaseService informationDatabaseService, 
            BaseMapper<Indigenouslands, IndigenouslandsResponse> baseMapper)
        {
            _indigenouslandsRepository = indigenouslandsRepository;
            _informationDatabaseService = informationDatabaseService;
            _baseMapper = baseMapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<IndigenouslandsResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var indigenouslandsTask = _indigenouslandsRepository.GetByGeometry(geom, cancellationToken);
            var informationResponse = await _informationDatabaseService.GetByNameAsync(
                Domain.Enumerations.InformationDatabaseType.Indigenouslands, cancellationToken);

            return GeoSpatialIntersectInformationResponseService
                .ToInformationReponse<Indigenouslands, IndigenouslandsResponse>(_baseMapper, await indigenouslandsTask, informationResponse);
        }
    }
}
