using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class TestController : ControllerBase
{
    [Authorize]
    public IActionResult ProtectedEndpoint()
    {
        return Ok("You have accessed a protected endpoint!");
    }
}
