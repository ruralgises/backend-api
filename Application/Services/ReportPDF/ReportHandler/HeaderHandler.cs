using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class HeaderHandler : BaseHandler
{
    public override void Handler(ColumnDescriptor column)
    {
        column
           .Item()
           .PaddingBottom(5)
           .Column(header =>
           {
               header
               .Item()
               .PaddingVertical(10)
               .Text("RELATÓRIO DE INFORMAÇÕES AMBIENTAIS")
               .FontSize(16)
               .Bold()
               .AlignCenter();
           });

        this._nextHandler?.Handler(column);
    }
}