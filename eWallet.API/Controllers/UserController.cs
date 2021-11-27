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

        [HttpPut("RequestAccountDeactivation/{Id}/{UserId}")]
        public IActionResult RequestAccountDeactivateUser()
        {
            return Ok();
        }

        [HttpPut("Deactivate/{Id}/{UserId}")]
         public IActionResult DeactivateUser()
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
