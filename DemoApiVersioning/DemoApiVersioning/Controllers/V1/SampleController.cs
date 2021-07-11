using Microsoft.AspNetCore.Mvc;

namespace DemoApiVersioning.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok("Test API");
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(string id)
        {
            return Ok(new { Id = id });
        }
    }
}