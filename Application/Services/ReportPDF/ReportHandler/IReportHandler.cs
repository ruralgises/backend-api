using System.Runtime.InteropServices;
using Application.DTOs.Response;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Application.Services.ReportPDF.ReportHandler;

public interface IReportHandler
{
    void SetNext(IReportHandler reportHandler);
    void Handler(ColumnDescriptor column, RuralPropertyResponse ruralProperty);
}