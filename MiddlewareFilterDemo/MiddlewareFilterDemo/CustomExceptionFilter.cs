using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareFilterDemo;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is MyCustomException exception)
        {
            var errorResponse = new
            {
                ErrorType = "Custom Business Error",
                Message = exception.Message
            };


            context.Result = new ObjectResult(errorResponse)
            {
                StatusCode = 400
            };

            context.ExceptionHandled = true;
        }
    }
}