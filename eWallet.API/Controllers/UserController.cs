using Microsoft.AspNetCore.Mvc;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
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


         [HttpPut("ChangeRole")]
         public IActionResult ChangeRole()
         {
             return Ok();
         }

         [HttpPut("Deactivate/{Id}/{UserId}")]
         public IActionResult DeactivateUser()
         {
             return Ok();
         }

    }
}
