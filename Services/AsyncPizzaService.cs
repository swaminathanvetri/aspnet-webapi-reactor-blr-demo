using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Services
{
    public class AsyncPizzaService : IAsyncPizzaService
    {
        List<Pizza> pizzas;
        ILogger<AsyncPizzaService> logger;

        public AsyncPizzaService(ILogger<AsyncPizzaService> _logger)
        {
            logger = _logger;
            pizzas = new List<Pizza>{
                new Pizza {Id =1 ,IsGlutenFree = true, Name="Peppy Panneer"},
                new Pizza {Id =2 ,IsGlutenFree = true, Name="Pepporoni"},
                new Pizza {Id =3 ,IsGlutenFree = true, Name="Double Cheese Margarita"},
            };
        }
        public async Task<List<Pizza>> GetAllPizzaAsync()
        {
            //simulating an async long running operation
            return await Task.Factory.StartNew(() =>
            {
                // Thread.Sleep(500);
                return pizzas;
            });
        }
    }
}