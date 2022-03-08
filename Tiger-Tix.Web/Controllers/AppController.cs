using Microsoft.AspNetCore.Mvc;
using Tiger_Tix.Web.ViewModels;

namespace Tiger_Tix.Web
{
    public class AppController : Controller
    {
        // [HttpPost("/")]
        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}