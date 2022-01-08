using Microsoft.AspNetCore.Mvc;

namespace eWallet.API.Controllers
{
    public class CurrencyContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
