using Application.DTOs.Response.Bases;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.QuestPDFExtensions
{
    public static class IntersectInformationHandlerExtension
    {
        public static void IntersectInformation<T>(
          this ColumnDescriptor descriptor,
          T informationResponse
        ) where T : GeoSpatialBaseIntersectionResponse
        {
            descriptor
                .Item()
                .BorderBottom(1)
                .Row(row =>
                {
                    row
                        .RelativeItem(4)
                        .TextInfo("Área (ha)",
                            informationResponse.AreaIntersectHa.ToString("N2"));

                    row
                        .RelativeItem(2)
                        .TextInfo("Área (%)",
                            informationResponse.PercentageOfThePropertyArea.ToString("N2"));
                });
        }
    }
}
