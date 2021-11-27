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
