using eWallet.API.DTOs;
using eWallet.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService user)
        {
            _userService = user;
        }

        [HttpPost("Register")]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            try
            {
                var response = await _userService.Login(model.email, model.password);
                if (!response.status)
                    return BadRequest("Error loging in ");
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }


        }

        [Authorize]
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

        
        [HttpPost("LogOut")]
        public IActionResult LogOut()
        {
            return Ok();
        }
    }
}
