using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler
{
    public class UseCoverageHandler : BaseHandler, IReportHandler
    {
        public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
        {
            column
               .Item()
               .PaddingVertical(5)
               .Column(column =>
               {
                   column
                   .InformationDataBase(ruralProperty.UseCoverage.InformationDatabase);

                   column
                   .IntersectInformationTotal(ruralProperty.UseCoverage);

                   foreach (var item in ruralProperty.UseCoverage.Values)
                   {
                       column
                       .Item()
                       .Row(row =>
                       {
                           row
                           .RelativeItem(3)
                           .TextInfo("Classe", item.Class.ToString());

                           row.RelativeItem(3)
                           .TextInfo("Nome", item.Name);
                       });

                       column
                        .IntersectInformation(item);
                   }
               });

            this._nextHandler?.Handler(column, ruralProperty);
        }
    }
               
}
