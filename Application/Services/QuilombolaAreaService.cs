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
    public class QuilombolaAreaService : IQuilombolaAreaService
    {
        private IQuilombolaAreasRepository _quilombolaAreasRepository {  get; init;}
        private IInformationDatabaseService _informationDatabaseService { get; init;}
        private BaseMapper<QuilombolaArea, QuilombolaAreaResponse> Mapper { get; init; }

        public QuilombolaAreaService(IQuilombolaAreasRepository quilombolaAreasRepository, IInformationDatabaseService informationDatabaseService, BaseMapper<QuilombolaArea, QuilombolaAreaResponse> mapper)
        {
            this._quilombolaAreasRepository = quilombolaAreasRepository;
            this._informationDatabaseService = informationDatabaseService;
            Mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<QuilombolaAreaResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var quilombolaAreaTask = _quilombolaAreasRepository.GetByGeometry(geom, cancellationToken);
            var information = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.QuilombolaArea, cancellationToken);

            return GeoSpatialIntersectInformationResponseService.ToInformationReponse<QuilombolaArea, QuilombolaAreaResponse>(Mapper, await quilombolaAreaTask, information);
        }
    }
}
