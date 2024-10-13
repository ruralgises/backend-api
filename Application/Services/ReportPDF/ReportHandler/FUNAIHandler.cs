using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class FUNAIHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
         .Item()
         .PaddingVertical(5)
         .Column(column =>
         {
             column
             .Item()
             .TextTitle("FUNAI - TERRA ÍNDIGENA");

             column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Código", "59301");

                  row.RelativeItem(4)
                  .TextInfo("Etnia", "Guarani Mbya,Tupiniquim");

                  row.RelativeItem(3)
                  .AlignRight()
                  .TextInfo("Fase", "Regularizada");
              });

             column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Nome", "Caieiras Velha II");

                  row.RelativeItem(5)
                  .AlignRight()
                  .TextInfo("Modalidade", "Tradicionalmente oculpada");
              });

             column
             .Item()
             .TextInfo("Unidade administrativa", "COORDENACAO REGIONAL DE MINAS GERAIS E ESPIRITO SANTO");

             column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Sigla", "CR-MGES");

                  row.RelativeItem(3)
                  .TextInfo("Código", "30202002067");
              });
         });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}