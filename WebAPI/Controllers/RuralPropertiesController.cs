using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RuralPropertiesController : ControllerBase
    {
        private IRuralPropertyService _RuralPropertyService { get; set; }

        public RuralPropertiesController(IRuralPropertyService ruralPropertyMinimumService)
        {
            _RuralPropertyService = ruralPropertyMinimumService;
        }

        [HttpGet("bycode")]
        public async Task<ActionResult<IList<RuralPropertyMinimumResponse>>> GetByCode([FromQuery] GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken = default)
        {
            var r = await _RuralPropertyService.GetByCode(request, cancellationToken);

            return Ok(r);
        }
    }
}
