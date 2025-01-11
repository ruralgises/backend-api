using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class DeforestationHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
          .Item()
          .PaddingVertical(5)
          .Column(column =>
          {
              column
              .InformationDataBase(ruralProperty.Deforestations.InformationDatabase,
              "Sobreposição com desflorestamento - " + ruralProperty.Deforestations.InformationDatabase.DatabaseName);

              column
              .IntersectInformationTotal(ruralProperty.Deforestations);

              foreach(var item in ruralProperty.Deforestations.Values)
              {
                  column
                  .Item()
                  .BorderBottom(1)
                  .Row(row =>
                  {
                      row
                      .RelativeItem(2)
                      .TextInfo("Ano", item.Year.ToString());

                      row.RelativeItem(2)
                      .TextInfo("Área(ha)", item.AreaIntersectHa.ToString());

                      row.RelativeItem(2)
                      .TextInfo("Área(%)", item.PercentageOfThePropertyArea.ToString());
                  });
              }
          });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}