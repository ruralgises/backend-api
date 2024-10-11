using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class IBAMAHandler : BaseHandler
{
    public override void Handler(ColumnDescriptor column)
    {
        column
           .Item()
           .PaddingVertical(5)
           .Column(column =>
           {
               column.Item().PageBreak();

               column
               .Item()
               .TextTitle("IBAMA - EMBARGOS");

               column
               .Item()
               .Row(row =>
               {
                   row
                   .RelativeItem(3)
                   .TextInfo("Identificação", "225224");

                   row.RelativeItem(3)
                   .AlignRight()
                   .TextInfo("Núm. processo adm.", "714719");
               });

               column
               .Item()
               .Row(row =>
               {
                   row
                   .RelativeItem(3)
                   .TextInfo("Data lavradura", "17/08/2016");

                   row.RelativeItem(3)
                   .AlignRight()
                   .TextInfo("Área embargada(ha)", "47.49");
               });

               column
               .Item()
               .Row(row =>
               {
                   row
                   .RelativeItem(3)
                   .TextInfo("Núm. do ato de infração", "9090768");

                   row.RelativeItem(3)
                   .AlignRight()
                   .TextInfo("Status", "Lavrado");
               });

               column
               .Item()
               .Row(row =>
               {
                   row
                   .RelativeItem(3)
                   .TextInfo("CPF", "764.750.347-20");

                   row.RelativeItem(3)
                   .AlignRight()
                   .TextInfo("Data de cadastro", "25/01/2017");
               });

               column
               .Item()
               .TextInfo("Nome", "Robson Rodrigues da Cunha Transportadora e Pedras Decorativas-Me");


               column
               .Item()
               .Row(row =>
               {
                   row
                   .RelativeItem(3)
                   .TextInfo("Legislação", "Decreto 3179/1999 - Artigo 2°");

                   row.RelativeItem(1)
                   .AlignRight()
                   .TextInfo("Artigo", "2");
               });

               column
               .Item()
               .BorderBottom(1)
               .TextInfo("Descrição", "Vender, expor à venda, exportar ou adquirir, guardar, ter em cativeiro ou depósito, utilizar ou transportar ovos, larvas ou espécimes da fauna silvestre, nativa ou em rota migratória, bem como produtos e objetos dela oriundos, provenientes de criadou");
           });

        this._nextHandler?.Handler(column);
    }
}