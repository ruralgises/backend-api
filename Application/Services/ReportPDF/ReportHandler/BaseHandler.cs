using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Application.Services.ReportPDF.ReportHandler;

public abstract class BaseHandler : IReportHandler
{
    protected IReportHandler? _nextHandler;

    public abstract void Handler(ColumnDescriptor container);

    public void SetNext(IReportHandler reportHandler)
    {
        _nextHandler = reportHandler;
    }
}