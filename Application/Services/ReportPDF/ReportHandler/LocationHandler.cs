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
                      .TextInfo("Município", item?.Municipality?.Name);

                      row.RelativeItem(2)
                      .TextInfo("Microrregião", item?.Microregion?.Name);

                      row.RelativeItem(2)
                      .TextInfo("Mesorregião", item?.Messoregion?.Name);
                  });

                  column
                 .Item()
                 .Row(row =>
                 {
                     row
                     .RelativeItem(2)
                     .TextInfo("Code", item?.Municipality?.Code);

                     row.RelativeItem(2)
                     .TextInfo("Code", item?.Microregion?.Code);

                     row.RelativeItem(2)
                     .TextInfo("Code", item?.Messoregion?.Code);
                 });
              });

            this._nextHandler?.Handler(column, ruralProperty);
        }
    }
}
