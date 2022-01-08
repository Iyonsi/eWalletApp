using eWallet.API.Commons;
using eWallet.API.DTOs;
using eWallet.API.Services;
using eWallet.API.Services.Implementations;
using eWallet.APIModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<User> _userManager;

        public AuthController(IAuthService authService, UserManager<User> userManager )
        {
            _authService = authService;
            _userManager = userManager;
        }

        [HttpPost("Register")]
        public IActionResult Register(UserToAdd user)
        {
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto model)
        {
           if (ModelState.IsValid)
            {
                ResponseDto<string> response = await _authService.Login(model.Email, model.Password);
                if (!response.Status)
                    return BadRequest("Error loging in ");
                return Ok(response);
            }

            ModelState.AddModelError("Failed", $"Invalid payLoad");
            return BadRequest(Util.BuildResponse<string>(false, "Unable to login", ModelState, ""));
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
