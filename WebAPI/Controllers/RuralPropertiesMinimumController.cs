using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuralPropertiesMinimumController : ControllerBase
    {
        private IRuralPropertyMinimumService _RuralPropertyMinimumService { get; set; }

        public RuralPropertiesMinimumController(IRuralPropertyMinimumService ruralPropertyMinimumService)
        {
            _RuralPropertyMinimumService = ruralPropertyMinimumService;
        }

        [HttpGet("bycode")]
        public async Task<ActionResult<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>>> GetByCode([FromQuery] GetByCodeRuralPropretiesMinimumRequest request, CancellationToken cancellationToken = default)
        {
            var r = await _RuralPropertyMinimumService.GetByCode(request, cancellationToken);

            return Ok(r);
        }

        [HttpGet("bycoordinate")]
        public async Task<ActionResult<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>>> GetByCoordinate([FromQuery]  GetByCoordinateRuralPropretiesMinimumRequest request, CancellationToken cancellationToken = default)
        {
            var r = await _RuralPropertyMinimumService.GetByCoordinate(request, cancellationToken);

            return Ok(r);
        }
    }
}
