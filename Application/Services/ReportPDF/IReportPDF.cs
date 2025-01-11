using Application.DTOs.Response;

namespace Application.Services.ReportPDF
{
    public interface IReportPDF
    {
        public byte[] Compose(RuralPropertyResponse ruralProperty);
    }
}
