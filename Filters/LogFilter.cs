using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace webapi.filters
{
    public class LogFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine($"Executing {context.HttpContext.Request.Path} with Query String {context.HttpContext.Request.QueryString}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine($"Executed {context.HttpContext.Request.Path} with Query String {context.HttpContext.Request.QueryString}");
        }
    }
}