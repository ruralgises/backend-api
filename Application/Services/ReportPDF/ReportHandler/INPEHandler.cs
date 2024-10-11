using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class INPEHandler : BaseHandler
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
              .TextTitle("INPE - DESMATAMENTO");

              //vai precisar de for
              column
              .Item()
              .Row(row =>
              {
                  row
                  .RelativeItem(3)
                  .TextInfo("Ano", "2008");

                  row.RelativeItem(3)
                  .TextInfo("Área(ha)", "1000.00");
              });
          });

        this._nextHandler?.Handler(column);
    }
}