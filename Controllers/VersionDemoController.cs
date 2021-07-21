using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/versiondemo")]
    public class VersionDemoController :ControllerBase
    {
        [HttpGet("hello")]
        [MapToApiVersion("1.0")]
        public ActionResult SayHello()
        {
           return Ok($"Hello");
        }
    }
}