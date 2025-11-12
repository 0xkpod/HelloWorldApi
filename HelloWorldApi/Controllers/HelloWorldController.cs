using System.Net.Mime;
using HelloWorldApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHelloWorld()
        {
            return Ok(new HelloWorldResponse("Hallo, verden", DateTime.Today));
        }
    }
}
