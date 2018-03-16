using Microsoft.AspNetCore.Mvc;
using TestServer.Core.Models;

namespace TestServer.Core.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HelloWorldController : Controller
    {
        [HttpGet("en"), MapToApiVersion("1.0")]
        public IActionResult GetHelloWorld()
        {
            return new ObjectResult(new Talker() {Hello = "Hello"});
        }

        [HttpGet("en"), MapToApiVersion("2.0")]
        public IActionResult GetHelloWorldV2()
        {
            return new ObjectResult(new Talker() { Hello = "Hello World" });
        }
    }
}