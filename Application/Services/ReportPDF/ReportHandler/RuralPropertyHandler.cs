using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Application.Services.ReportPDF.ReportHandler;

public class RuralPropertyHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
        .Item()
            .PaddingBottom(5)
            .BorderBottom(1)
            .Column(column =>
            {
                column
                .InformationDataBase(ruralProperty.InformationDatabase,
                "Propriedade rural - " + ruralProperty.InformationDatabase.DatabaseName);

                column
                .Item()
                .TextInfo("Código do Imóvel", ruralProperty.Code);

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(4)
                    .TextInfo("Situação do cadastro", ruralProperty.Condition);

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Status", "Cancelado");
                });

                column
                .Item()
                .Row(row =>
                {
                    row.RelativeItem(4)
                    .TextInfo("Nome do tema", ruralProperty.ThemeName);

                    row.RelativeItem(2)
                    .AlignRight()
                    .TextInfo("Tipo de ímovel", ruralProperty.Type);
                });

                column
                .Item()
                .Row(row =>
                {
                    row.RelativeItem(4)
                    .TextInfo("Área total(ha)", ruralProperty.AreaHa.ToString());
                });

            });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}