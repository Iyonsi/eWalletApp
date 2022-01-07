﻿using eWallet.API.DTOs;
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
        public IActionResult Register(UserToAdd user)
        {
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto model)
        {
           if (ModelState.IsValid)
            {
                ResponseDto<string> response = await _userService.Login(model.Email, model.Password);
                if (!response.LoginStatus)
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
