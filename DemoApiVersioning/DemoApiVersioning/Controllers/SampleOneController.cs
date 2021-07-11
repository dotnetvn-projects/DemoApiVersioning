using Microsoft.AspNetCore.Mvc;

namespace DemoApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    [Route("[controller]")]
    public class SampleOneController : ControllerBase
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