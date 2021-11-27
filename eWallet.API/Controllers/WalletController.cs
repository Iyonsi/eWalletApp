using Microsoft.AspNetCore.Mvc;

namespace eWallet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalletController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult CreateWallet()
        {
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult UpdateWallet()
        {
            return Ok();
        }

        [HttpGet("GetWallets/{Id}")]
        public IActionResult GetAWalletById()
        {
            return Ok();
        }

        [HttpGet("GetAllWallets")]
        public IActionResult GetAllWalletsById()
        {
            return Ok();
        }

        [HttpDelete("Delete/{Id}")]
        public IActionResult DeleteWallet()
        {
            return Ok(0);
        }
    }
}
