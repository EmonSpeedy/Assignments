using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareFilterDemo
{
    public class CustomHeaderActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception == null)
            {
                context.HttpContext.Response.Headers.Append("X-Custom-Header", "Processed-Successfully");
            }
        }
    }
}