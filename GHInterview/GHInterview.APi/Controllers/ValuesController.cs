using GHInterview.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GHInterview.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueService _service;
        public ValuesController(IValueService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var valueStr = _service.GetValue();
            return Ok(valueStr);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
