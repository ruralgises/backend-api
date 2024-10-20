using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler
{
    public class QuilombolaAreaHandler : BaseHandler, IReportHandler
    {
        public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
        {
            column
               .Item()
               .PaddingVertical(5)
               .Column(column =>
               {
                   column
                   .InformationDataBase(ruralProperty.QuilombolaAreas.InformationDatabase);

                   column
                   .IntersectInformationTotal(ruralProperty.QuilombolaAreas);

                   foreach (var item in ruralProperty.QuilombolaAreas.Values)
                   {
                        column
                        .Item()
                        .Row(row =>
                        {
                            row
                            .RelativeItem(3)
                            .TextInfo("Processo", item.ProcessNumber);

                            row.RelativeItem(3)
                            .AlignRight()
                            .TextInfo("Comunidade", item.CommunityName);
                        });

                        column
                        .Item()
                        .Row(row =>
                        {
                            row.RelativeItem(3)
                            .TextInfo("Fámilia", item.FamilyNumber.ToString());

                            row.RelativeItem(3)
                            .AlignRight()
                            .TextInfo("Data Decreto", item.FamilyNumber.ToString());
                        });

                        column
                        .Item()
                        .Row(row =>
                        {
                            row.RelativeItem(2)
                            .TextInfo("Esfera", item.Realm);

                            row.RelativeItem(2)
                            .TextInfo("Fase", item.Phase);

                            row.RelativeItem(2)
                            .AlignRight()
                            .TextInfo("Responsável", item.Responsible);
                        });

                       column
                        .IntersectInformation(item);
                   }

                   this._nextHandler?.Handler(column, ruralProperty);
               });
        }
    }
}
