using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class IBGEHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
            .Item()
            .PaddingVertical(5)
            .Column(column =>
            {
                column
                .Item()
                .TextTitle("IBGE - GEOLOCALIZAÇÃO");

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(5)
                    .TextInfo("Messoregião", "Litoral Norte Espírito-santense");

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Código", "3203");
                });

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(5)
                    .TextInfo("Microregião", "Cachoeiro de Itapemirim");

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Código", "3204252");
                });

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(5)
                    .TextInfo("Munícipio", "Venda Nova do Imigrante");

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Código", "3204252");
                });
            });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}