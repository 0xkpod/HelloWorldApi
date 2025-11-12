using System.Net.Mime;
using HelloWorldApi.Requests;
using HelloWorldApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class GreetingController : ControllerBase
    {
        private readonly Random _random = new();
        private static readonly IReadOnlyList<string> Greetings = 
        [
            "Hei",
            "Hallo",
            "Hei, hei",
            "God dag",
            "God morgen",
            "God kveld",
            "Heisann",
            "Morn",
            "Hyggelig å møte deg"
        ];

        [HttpGet]
        public IActionResult GetRandomGreetings()
        {
            var greeting = Greetings[_random.Next(Greetings.Count)];
            var response = new GreetingResponse(greeting);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(GreetingResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public IActionResult SendGreetingsTo([FromBody] GreetingRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                return BadRequest(new ErrorResponse("Name cannot be empty.", DateTime.Now));
            
            var greeting = Greetings[_random.Next(Greetings.Count)];
            var fullGreeting = $"{greeting}, {request.Name}!";
            var response = new GreetingResponse(fullGreeting); 
            return CreatedAtAction(nameof(GetRandomGreetings), response);
        }
    }
}
