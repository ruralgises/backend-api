using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class ConservationUnitHandler : BaseHandler
{
    public override void Handler(ColumnDescriptor column)
    {
        column
          .Item()
          .PaddingVertical(5)
          .Column(column =>
          {
              column
             .Item()
             .TextTitle("CNUC - UNIDADE DE CONSERVAÇÃO");

              column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Nome", "Reserva Biológica de Sooretama");

                  row.RelativeItem(3)
                  .AlignRight()
                  .TextInfo("Categoria", "Reserva Biológica");
              });

              column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Código", "0000.32.3452");

                  row.RelativeItem(3)
                  .TextInfo("Fase", "Regularizada");

                  row.RelativeItem(3)
                  .AlignRight()
                  .TextInfo("Esfera", "Federal");
              });

              column
              .Item()
              .TextInfo("Órgão gestor", "INSTITUTO CHICO MENDES DE CONSERVAÇÃO DA BIODIVERSIDADE");

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
                  .TextInfo("Data de criação", "28/02/1984");

                  row
                  .RelativeItem(3)
                  .TextInfo("Grupo", "Proteção Integral");
              });

              column
              .Item()
              .Row(row =>
              {


                  row.RelativeItem(3)
                  .TextInfo("Ato de criação", "Decreto 90.347/1984");
              });
          });


        this._nextHandler?.Handler(column);
    }
}