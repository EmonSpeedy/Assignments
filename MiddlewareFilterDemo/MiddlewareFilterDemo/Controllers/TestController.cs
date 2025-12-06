using Microsoft.AspNetCore.Mvc;

namespace MiddlewareFilterDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] bool throwError = false)
    {
        if (throwError)
        {
            throw new MyCustomException("You explicitly requested an error!");
        }
        return Ok(new { message = "Success" });
    }
}