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

        [HttpPost("bygeometry")]
        public async Task<ActionResult<GeoSpatialInformationResponse<RuralPropertyMinimumResponse>>> GetByGeometry([FromBody]  GetByGeometryRuralPropretiesMinimumRequest request, CancellationToken cancellationToken = default)
        {
            request.Geometry.SRID = 4674;
            var r = await _RuralPropertyMinimumService.GetByGeometry(request, cancellationToken);
            return Ok(r);
        }
    }
}
