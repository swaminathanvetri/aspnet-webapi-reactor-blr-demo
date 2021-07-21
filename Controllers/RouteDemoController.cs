using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    // Demo controller to showcase different kinds of routing options in web api
    [ApiController]
    public class RouteDemoController : ControllerBase
    {  
        ILogger<ControllerBase> logger;
        public RouteDemoController(ILogger<ControllerBase> _logger)
        {
            logger = _logger;
        }
         
        [HttpGet]
        [Route("[controller]/hello")]
        public IActionResult SayHelloQuery([FromQuery] string message, [FromQuery] string salutation)
        {
            return Ok($"{salutation}. {message}");
        }
        
        [HttpGet]
        [Route("/api/routedemo/hello/{message}")]
        public IActionResult SayHelloRoute([FromRoute]string message,[FromQuery] string salutation)
        {
            return Ok($"{salutation}. {message}");
        }

        [HttpPost]
        [Route("/api/routedemo/hello")]
        [Consumes("text/plain")]
        [ProducesResponseType(201)]
        public IActionResult Create(string message)
        {
            return CreatedAtAction(nameof(this.Create), $"Hello {message}");
        }

        [HttpPost]
        [Route("/api/routedemo/helloJson")]
        [Consumes("application/json")]
        public IActionResult CreateFromJson(MessageModel incomingMessage)
        {
            return CreatedAtAction(nameof(this.Create), $"Hello {incomingMessage.Salutation}.{incomingMessage.Message}");
        }
    }
}

