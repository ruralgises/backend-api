using Application.DTOs.Response;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.QuestPDFExtensions
{
    public static class InformationHandlerExtension
    {
        public static void InformationDataBase(
            this ColumnDescriptor descriptor,
            InformationDatabaseResponse informationResponse,
            string databaseDecription
        )
        {
            descriptor
                  .Item()
                  .TextTitle(databaseDecription);

            descriptor
                .Item()
                .Row(row =>
                {
                    row
                        .RelativeItem(3)
                        .TextInfo("Governamental", informationResponse.IsOfficial ? "Sim" : "Não");
                    row
                        .RelativeItem(3)
                        .AlignRight()
                        .TextInfo(
                            "Ultima atualização", 
                            informationResponse.LastUpdate.ToString("dd/MM/yyyy")
                        );
                });
        }
    }
}
