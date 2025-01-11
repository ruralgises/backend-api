using Application.DTOs.Response.Bases;
using QuestPDF.Fluent;

namespace Application.Services.ReportPDF.QuestPDFExtensions
{
    public static class IntersectInformationTotalHandlerExtension
    {
        public static void IntersectInformationTotal<T>(
            this ColumnDescriptor descriptor,
            GeoSpatialIntersectInformationResponse<T> informationResponse
        ) where T : GeoSpatialBaseIntersectionResponse
        {
            descriptor
            .Item()
            .BorderBottom(1)
            .Row(row =>
            {
                row
                .RelativeItem(4)
                .TextInfo("Área total (ha)",
                    informationResponse.AreaIntersectTotalHa.ToString("N2"));

                row
                .RelativeItem(2)
                .TextInfo("Área total (%)",
                    informationResponse.PercentageOfThePropertyAreaTotal.ToString("N2"));
            });
        }
    }
}
