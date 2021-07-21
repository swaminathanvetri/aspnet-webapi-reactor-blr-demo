using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsyncDemoController : ControllerBase
    {
        IAsyncPizzaService asyncPizzaService;
        public AsyncDemoController(IAsyncPizzaService _asyncPizzaService)
        {
            asyncPizzaService = _asyncPizzaService;
        }
        [HttpGet]
        [Route("getAll")]
        public async Task<List<Pizza>> GetPizzasAsync()
        {
            return await asyncPizzaService.GetAllPizzaAsync();
        }
        
    }
}