using eWallet.API.DTOs;
using eWallet.API.Services;
using eWallet.APIModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("get-users")]
        public IActionResult GetUsers()
        {
            // map data from db to dto to reshape it and remove null fields
            var listOfUsersToReturn = new List<UserToReturnDto>();
            var users = _userService.Users;
            if (users != null)
            {
                foreach (var user in users)
                {
                    listOfUsersToReturn.Add(new UserToReturnDto
                    {
                        Id = user.Id,
                        LastName = user.LastName,
                        FirstName = user.FirstName,
                        Email = user.Email
                    });
                }
                return Ok(listOfUsersToReturn);
            }
            else
            {
                return NotFound("No results found!");
            }

        }


        [HttpGet("get-user")]
        public async Task<IActionResult> GetUser(string email)
        {
            // map data from db to dto to reshape it and remove null fields
            var UserToReturn = new UserToReturnDto();
            var user = await _userService.GetUser(email);
            if (user != null)
            {
                UserToReturn = new UserToReturnDto
                {
                    Id = user.Id,
                    LastName = user.LastName,
                    FirstName = user.FirstName,
                    Email = user.Email
                };
                return Ok(UserToReturn);
            }
            else
            {
                return NotFound("No results found!");
            }

        }
       

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser(RegisterDto model)
        {
            // Map DTO to User
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };

            try
            {
                var response = await _userService.Register(user, model.Password);
                if (response.Status)
                {
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return BadRequest("User not added");

        }

        [HttpGet("UserDetails/{Id}")]
        public IActionResult GetUsersById()
        {
            return Ok();
        }


        [HttpGet("AllUsers")]
        public IActionResult AllUsers()
        {
            return Ok();
        }

         [HttpGet("Role/{Id}")]
         public IActionResult GetUsersByRole()
         {
             return Ok();
         }


         [HttpPut("Role/Change")]
         public IActionResult ChangeRole()
         {
             return Ok();
         }

        [HttpPut("Deactivation/Approve")]
        public IActionResult ApproveDeactivateUser()
        {
            return Ok();
        }

        [HttpPut("Deactivation/Request/{Id}/{UserId}")]
        public IActionResult RequestAccountDeactivateUser()
        {
            return Ok();
        }

        [HttpPut("Deactivate/{Id}/{UserId}")]
         public IActionResult DeactivateUser()
         {
             return Ok();
         }

        [HttpPut("User/Update")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

      
    }
}
