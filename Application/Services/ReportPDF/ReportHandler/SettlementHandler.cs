using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler
{
    public class SettlementHandler : BaseHandler, IReportHandler
    {
        public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
        {
            column
               .Item()
               .PaddingVertical(5)
               .Column(column =>
               {
                   column
                   .InformationDataBase(ruralProperty.Settlements.InformationDatabase,
                   "Sobreposição com assentamentos - " + ruralProperty.Settlements.InformationDatabase.DatabaseName);

                   column
                   .IntersectInformationTotal(ruralProperty.Settlements);

                   foreach (var item in ruralProperty.Settlements.Values)
                   {
                       column
                       .Item()
                       .Row(row =>
                       {
                           row
                           .RelativeItem(3)
                           .TextInfo("SIPRA", item.CodeSIPRA);

                           row.RelativeItem(3)
                           .AlignRight()
                           .TextInfo("Comunidade", item.NameProject);
                       });

                       column
                       .Item()
                       .Row(row =>
                       {
                           row
                           .RelativeItem(3)
                           .TextInfo("Família", item.FamilyNumber.ToString());

                           row.RelativeItem(3)
                           .AlignRight()
                           .TextInfo("Criação", item.CreationDate);
                       });

                       column
                       .Item()
                       .Row(row =>
                       {
                           row
                           .RelativeItem(3)
                           .TextInfo("Forma obtenção", item.WayObtaining);

                           row.RelativeItem(3)
                           .AlignRight()
                           .TextInfo("Obtenção", item.DateObtaining);
                       });

                       column
                        .IntersectInformation(item);
                   }
               });

            this._nextHandler?.Handler(column, ruralProperty);
        }
    }
}
