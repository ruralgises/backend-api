using Application.DTOs.Request;

namespace Application.Interfaces.Services
{
    public interface IReportPDFService
    {
        public Task<byte[]?> GetReportPDF(GetByCodeRuralPropretiesRequest CAR, CancellationToken cancellationToken);
    }
}
