using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class IndigenouslandsHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
         .Item()
         .PaddingVertical(5)
         .Column(column =>
         {
             column
              .InformationDataBase(ruralProperty.Indigenousland.InformationDatabase);

             column
             .IntersectInformationTotal(ruralProperty.Indigenousland);

             foreach(var item in ruralProperty.Indigenousland.Values)
             {
                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(3)
                    .TextInfo("Código", item.LandCode.ToString());

                    row.RelativeItem(4)
                    .TextInfo("Etnia", item.EthnicityName);

                    row.RelativeItem(3)
                    .AlignRight()
                    .TextInfo("Fase", item.IndigenousLandCreationPhase);
                });

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(3)
                    .TextInfo("Nome", item.LandName);

                    row.RelativeItem(5)
                    .AlignRight()
                    .TextInfo("Modalidade", item.Modality);
                });

                column
                .Item()
                .TextInfo("Unidade administrativa", item.adminUnitName);

                column
                .Item()
                .Row(row =>
                {
                    row
                    .RelativeItem(3)
                    .TextInfo("Sigla", item.adminUnitAcronym);

                    row.RelativeItem(3)
                    .TextInfo("Código", item.adminUnitCode);
                });

                 column
                   .IntersectInformation(item);
             }
         });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}