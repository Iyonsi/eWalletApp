using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost("Login")]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost("Forget PassWord")]
        public IActionResult ForgetPassWord()
        {
            return Ok();
        }

        [HttpPost("ResetPassWord")]
        public IActionResult ResetPassWord()
        {
            return Ok();
        }

        [Authorize]
        [HttpPost("LogOut")]
        public IActionResult LogOut()
        {
            return Ok();
        }
    }
}
