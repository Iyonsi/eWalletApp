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

        [HttpPut("Update/Default")]
        public IActionResult SetDefaultWallet()
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
        [HttpPost("Create/Currency")]
        public IActionResult CreateWalletCurrency()
        {
            return Ok();
        }

        [HttpPut("Update/Currency")]
        public IActionResult UpdateWalletCurrency()
        {
            return Ok();
        }

        [HttpPut("Update/Currency/Default{Id}")]
        public IActionResult SetDefaultWalletCurrency()
        {
            return Ok();
        }

        [HttpGet("Currency/{Id}")]
        public IActionResult GetWalletCurrency()
        {
            return Ok();
        }

        [HttpGet("AllCurrencies")]
        public IActionResult GetAllWalletCurrency()
        {
            return Ok();
        }

        [HttpDelete("Currency/{Id}")]
        public IActionResult DeleteWalletCurrency()
        {
            return Ok();
        }

    }
}
