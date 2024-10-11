using Application.Services.ReportPDF.ReportHandler;

namespace Application.Services.ReportPDF.ReportHandlerFactories;

public interface IReportHandlerFactory
{
    public IReportHandler Create();
}
