using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler
{
    public class LocationHandler : BaseHandler, IReportHandler
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
                    .InformationDataBase(ruralProperty.Location.InformationDatabase);

                  var item = ruralProperty.Location;

                  column
                  .Item()
                  .Row(row =>
                  {
                      row
                      .RelativeItem(2)
                      .TextInfo("Município", item?.MunicipalityResponse?.Name);

                      row.RelativeItem(2)
                      .TextInfo("Microrregião", item?.MicroregionResponse?.Name);

                      row.RelativeItem(2)
                      .TextInfo("Mesorregião", item?.MessoregionResponse?.Name);
                  });

                  column
                 .Item()
                 .Row(row =>
                 {
                     row
                     .RelativeItem(2)
                     .TextInfo("Code", item?.MunicipalityResponse?.Code);

                     row.RelativeItem(2)
                     .TextInfo("Code", item?.MicroregionResponse?.Code);

                     row.RelativeItem(2)
                     .TextInfo("Code", item?.MessoregionResponse?.Code);
                 });
              });

            this._nextHandler?.Handler(column, ruralProperty);
        }
    }
}
