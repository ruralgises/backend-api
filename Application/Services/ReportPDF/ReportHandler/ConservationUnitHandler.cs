using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;
using System.Runtime.CompilerServices;

namespace Application.Services.ReportPDF.ReportHandler;

public class ConservationUnitHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
          .Item()
          .PaddingBottom(5)
          .Column(column =>
          {
              column
             .InformationDataBase(ruralProperty.ConservationUnits.InformationDatabase,
             "Sobreposição com unidades de conservação - " + ruralProperty.ConservationUnits.InformationDatabase.DatabaseName);

              column
              .IntersectInformationTotal(ruralProperty.ConservationUnits);

              foreach(var item in ruralProperty.ConservationUnits.Values)
              {
                  column
                  .Item()
                  .Row(row =>
                  {
                      row
                      .RelativeItem(3)
                      .TextInfo("Nome", item.UCName);

                      row.RelativeItem(3)
                      .AlignRight()
                      .TextInfo("Categoria", item.Category);
                  });

                  column
                  .Item()
                  .Row(row =>
                  {
                      row
                      .RelativeItem(3)
                      .TextInfo("Código", item.CNUCCode);

                      row.RelativeItem(3)
                      .AlignRight()
                      .TextInfo("Esfera", item.Realm);
                  });

                  column
                  .Item()
                  .TextInfo("Órgão gestor", item.ManagingBody);

                  column
                  .Item()
                  .Row(row =>
                  {

                  });

                  //grupo, esfera, data criação, ato de criação,
                  column
                  .Item()
                  .Row(row =>
                  {
                      row
                      .RelativeItem(3)
                      .TextInfo("Data de criação", item.YearCreation);

                      row
                      .RelativeItem(3)
                      .TextInfo("Grupo", item.Group);
                  });

                  column
                  .Item()
                  .Row(row =>
                  {
                      row.RelativeItem(3)
                      .TextInfo("Ato de criação", item.ActCreation);
                  });

                  column
                  .IntersectInformation(item);
              }
          });


        this._nextHandler?.Handler(column, ruralProperty);
    }
}