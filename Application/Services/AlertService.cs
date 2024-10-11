using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AlertService : IAlertService
    {
        private IAlertRepository _alertRepository { get; init; }
        private IInformationDatabaseService _informationDatabaseService { get; init; }
        private BaseMapper<Alert, AlertResponse> _mapper {  get; init; }

        public AlertService(
            IAlertRepository alertRepository, 
            IInformationDatabaseService informationDatabaseService, 
            BaseMapper<Alert, AlertResponse> mapper)
        {
            _alertRepository = alertRepository;
            _informationDatabaseService = informationDatabaseService;
            _mapper = mapper;
        }

        public async Task<GeoSpatialIntersectInformationResponse<AlertResponse>> GetByGeometry(Geometry geom, CancellationToken cancellationToken)
        {
            var alertTask = _alertRepository.GetByGeometry(geom, cancellationToken);

            var informationResponse = await _informationDatabaseService.GetByNameAsync(Domain.Enumerations.InformationDatabaseType.Alert, cancellationToken);

            var r = GeoSpatialIntersectInformationResponseService.ToInformationReponse<Alert, AlertResponse>(_mapper, await alertTask, informationResponse);

            return r;
        }
    }
}
