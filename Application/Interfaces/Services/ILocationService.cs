using Application.DTOs.Response;

namespace Application.Interfaces.Services
{
    public interface ILocationService
    {
        //public Task<LocationResponse> GetByGeometry(Geometry geom, CancellationToken cancellationToken);
        public Task<LocationResponse> GetByMunipalityName(string MunicipalyName, CancellationToken cancellationToken);
    }
}
