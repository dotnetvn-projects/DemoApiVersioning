using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoApiVersioning.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public class SampleController : V1.SampleController
    {
        [HttpGet("{id}")]
        public override IActionResult Get(string id)
        {
            return Ok(new { Id = id, Name = $"{Guid.NewGuid()}" });
        }
    }
}