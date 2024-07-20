using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class UseCoverageService : IUseCoverageService
    {
        private IUseCoverageRepository _useCoverageRepository {  get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }

        private BaseMapper<UseCoverage, UseCoverageResponse> Mapper { get; init; }

        public UseCoverageService(IUseCoverageRepository useCoverageRepository, IInformationDatabaseService informationDatabaseService, BaseMapper<UseCoverage, UseCoverageResponse> mapper)
        {
            _useCoverageRepository = useCoverageRepository;
            _informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<UseCoverageResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var useCoverageTask = _useCoverageRepository.GetByGeometry(geom, cancellationToken);
            var useCoverageResponse = Mapper.ToResponses(await useCoverageTask);

            var groupedResults = useCoverageResponse
                .GroupBy(r => new { r.Class, r.Name })
                .Select(g => new UseCoverageResponse
                {
                    Class = g.Key.Class,
                    Name = g.Key.Name,
                    AreaIntersectHa = g.Sum(r => r.AreaIntersectHa)
                }).ToList();

            var information = await _informationDatabaseService.GetByNameAsync(Entity.UseCoverage, cancellationToken);

            var r = GeoSpatialIntersectInformationResponseMapper.ToInformationReponse<UseCoverageResponse>(groupedResults.ToList(), information);

            return r;
        }
    }
}
