namespace MiddlewareFilterDemo;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"[Middleware Log] Incoming Request: {context.Request.Method} {context.Request.Path}");
        await _next(context);
    }
}