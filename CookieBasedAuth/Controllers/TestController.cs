using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookieBasedAuth.Controllers
{
    public class TestController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content("Authorized");
        }
    }
}
