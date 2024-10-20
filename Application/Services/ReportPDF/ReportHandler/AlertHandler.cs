using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using NetTopologySuite.Index.HPRtree;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler
{
    public class AlertHandler : BaseHandler, IReportHandler
    {
        public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
        {
            column
              .Item()
              .PaddingBottom(5)
              .Column(column =>
              {
                  column
                 .InformationDataBase(ruralProperty.Alert.InformationDatabase);

                  column
                  .IntersectInformationTotal(ruralProperty.Alert);

                  foreach (var item in ruralProperty.Alert.Values)
                  {
                      column
                      .Item()
                      .Row(row =>
                      {
                          row
                          .RelativeItem(2)
                          .TextInfo("Código", item.CodeAlert.ToString());

                          row.RelativeItem(2)
                          .TextInfo("Vetor Pressão", item.VectorPressure);

                          row.RelativeItem(2)
                          .TextInfo("Fonte", item.Font);
                      });

                      column
                      .Item()
                      .Row(row =>
                      {
                          row
                          .RelativeItem(3)
                          .TextInfo("Detecção", item.DetectDate.ToString("dd/MM/yyyy"));

                          row.RelativeItem(3)
                          .AlignRight()
                          .TextInfo("Publicação", item.PublicationDate.ToString("dd/MM/yyyy"));
                      });

                      column
                        .IntersectInformation(item);
                  }
              });
        }
    }
}
