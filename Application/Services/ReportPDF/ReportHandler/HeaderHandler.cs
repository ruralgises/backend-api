using Application.DTOs.Response;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class HeaderHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
           .Item()
           .PaddingBottom(5)
           .Column(header =>
           {
               header
               .Item()
               .PaddingVertical(10)
               .Text("RELATÓRIO")
               .FontSize(16)
               .Bold()
               .AlignCenter();
           });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}