using Application.Services.ReportPDF.ReportHandler;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Application.Services.ReportPDF;

public class ReportPDF
{
    private IReportHandler? _reportHandler;

    public ReportPDF(IReportHandler reportHandler)
    {
        _reportHandler = reportHandler;
    }
    public Document Compose()
    {
        Document doc = Document.Create(container =>
        {
            container.Page(
            page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Content().Column(
                    column =>
                    {
                        this._reportHandler?.Handler(column);
                    });
            }
        );
        }
        );

        return doc;
    }
}
