using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [ApiExplorerSettings(IgnoreApi =true)]
    [Route("api/v{version:apiVersion}/versiondemo")]
    public class VersionDemoV2Controller :ControllerBase
    {
        [HttpGet("hello")]
        [MapToApiVersion("2.0")]
        [ProducesResponseType(typeof(string), 200)]
        public ActionResult SayHello([Required]string message)
        {
           return Ok($"Hello {message}");
        }
    }
}