using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi
{
    public interface IAsyncPizzaService
    {
        public Task<List<Pizza>> GetAllPizzaAsync();
    }
}