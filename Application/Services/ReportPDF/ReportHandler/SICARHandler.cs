using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Application.Services.ReportPDF.ReportHandler;

public class SICARHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
        .Item()
            .PaddingBottom(5)
            .Column(column =>
            {
                column
                .Item()
                .TextTitle("SICAR - IMÓVEL RURAL");

                column
                .Item()
                .TextInfo("Código do Imóvel", "ES-3201100-D0FC04294D724C49889D805DB29BD3FF");

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(4)
                    .TextInfo("Situação do cadastro", "Cancelado por decisao administrativa");

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Status", "Cancelado");
                });

                column
                .Item()
                .Row(row =>
                {
                    row.RelativeItem(4)
                    .TextInfo("Nome do tema", "Área de Preservação Permanente");

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Tipo de ímovel", "IRU");
                });

                column
                .Item()
                .Row(row =>
                {
                    row.RelativeItem(4)
                    .TextInfo("Área total(ha)", "1000.00");
                });

            });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}