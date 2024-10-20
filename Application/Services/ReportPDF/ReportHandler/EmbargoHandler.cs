using Application.DTOs.Response;
using Application.Services.ReportPDF.QuestPDFExtensions;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.ReportHandler;

public class EmbargoHandler : BaseHandler, IReportHandler
{
    public override void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty)
    {
        column
           .Item()
           .PaddingVertical(5)
           .Column(column =>
           {
               //column.Item().PageBreak();

               column
               .InformationDataBase(ruralProperty.Embargoes.InformationDatabase);

               column
               .IntersectInformationTotal(ruralProperty.Embargoes);

              foreach(var item in ruralProperty.Embargoes.Values)
              {
                   column
                  .Item()
                  .Row(row =>
                  {
                      row
                      .RelativeItem(3)
                      .TextInfo("Identificação", item.AdministrativeProcessNumber);

                      row.RelativeItem(3)
                      .AlignRight()
                      .TextInfo("Núm. processo adm.", item.IdentificationEmbargoTerm);
                  });

                   column
                   .Item()
                   .Row(row =>
                   {
                       row
                       .RelativeItem(3)
                       .TextInfo("Data lavradura", item.EmbargoIssuanceDate.ToString("dd/MM/yyyy"));

                       row.RelativeItem(3)
                       .AlignRight()
                       .TextInfo("Área embargada(ha)", item.TotalEmbargoArea);
                   });

                   column
                   .Item()
                   .Row(row =>
                   {
                       row
                       .RelativeItem(3)
                       .TextInfo("Núm. do ato de infração", item.InflationActNumber);

                       row.RelativeItem(3)
                       .AlignRight()
                       .TextInfo("Status", item.Status);
                   });

                   column
                   .Item()
                   .Row(row =>
                   {
                       row
                       .RelativeItem(3)
                       .TextInfo("CPF/CNPJ", item.CPF_CNPJ);

                       row.RelativeItem(3)
                       .AlignRight()
                       .TextInfo("Data de cadastro", item.RegistrationDate.ToString("dd/MM/yyyy"));
                   });

                   column
                   .Item()
                   .TextInfo("Nome", item.NameEmbargoed);


                   column
                   .Item()
                   .Row(row =>
                   {
                       row
                       .RelativeItem(3)
                       .TextInfo("Legislação", item.Legislation);

                       row.RelativeItem(1)
                       .AlignRight()
                       .TextInfo("Artigo", item.Article);
                   });

                   column
                   .Item()
                   .TextInfo("Descrição",  item.InfractionDescription);

                   column
                   .IntersectInformation(item);
               }
           });

        this._nextHandler?.Handler(column, ruralProperty);
    }
}