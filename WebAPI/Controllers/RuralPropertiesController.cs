using Application.DTOs.Request;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RuralPropertiesController : ControllerBase
    {
        private IRuralPropertyService _RuralPropertyService { get; set; }
        private IReportPDFService _ReportPDFService { get; set; }

        public RuralPropertiesController(IRuralPropertyService ruralPropertyMinimumService, IReportPDFService reportPDFService)
        {
            _RuralPropertyService = ruralPropertyMinimumService;
            _ReportPDFService = reportPDFService;
        }

        [HttpGet()]
        public async Task<ActionResult> GetByCode([FromQuery] GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken = default)
        {
            var r = await _RuralPropertyService.GetByCode(request, cancellationToken);

            if (r == null)
            {
                return NotFound();
            }

            return Ok(r);
        }

        [HttpGet("report")]
        public async Task<IActionResult> GetReport([FromQuery] GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken = default)
        {
            var pdf = await _ReportPDFService.getReportPDF(request, cancellationToken);

            if (pdf == null)
            {
                return NotFound();
            }

            return File(pdf, "application/pdf", $"report-{request.Code}.pdf");
        }
    }
}
