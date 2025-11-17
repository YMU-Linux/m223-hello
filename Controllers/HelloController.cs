using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("Hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
    public IActionResult HelloWorld()
    {
        return Ok("Hello Modul 223");
    }
    }
}
