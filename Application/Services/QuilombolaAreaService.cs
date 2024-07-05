using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;

namespace Application.Services
{
    public class QuilombolaAreaService : IQuilombolaAreaService
    {
        private IQuilombolaAreasRepository _quilombolaAreasRepository {  get; init;}
        private IInformationDatabaseService _informationDatabaseService { get; init;}

        public QuilombolaAreaService(IQuilombolaAreasRepository quilombolaAreasRepository, IInformationDatabaseService informationDatabaseService)
        {
            this._quilombolaAreasRepository = quilombolaAreasRepository;
            this._informationDatabaseService = informationDatabaseService;
        }

        public async Task<GeoSpatialIntersectInformationResponse<QuilombolaAreaResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var quilombolaArea = _quilombolaAreasRepository.GetByGeometry(geom, cancellationToken);
            var quilombolaAreaResponse = QuilombolaAreaMapper.ToResponse(await quilombolaArea);

            var information = await _informationDatabaseService.GetByNameAsync(Entity.QuilombolaArea, cancellationToken);

            return GeoSpatialIntersectInformationResponseMapper.ToInformationReponse(quilombolaAreaResponse, information);
        }
    }
}
