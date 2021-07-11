using Microsoft.AspNetCore.Mvc;

namespace DemoApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public class SampleTwoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test API");
        }

        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public IActionResult Get(string id)
        {
            return Ok(new { Id = id });
        }
    }
}