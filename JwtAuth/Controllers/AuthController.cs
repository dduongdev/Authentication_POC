using JwtAuth.Models;
using JwtAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Simple hardcoded authentication for demonstration purposes
            if (model.Username == "admin" && model.Password == "password")
            {
                var token = _authService.GenerateJwtToken(model.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
}
