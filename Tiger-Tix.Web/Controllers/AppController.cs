using Microsoft.AspNetCore.Mvc;
using Tiger_Tix.Web.ViewModels;

namespace Tiger_Tix.Web
{
    public class AppController : Controller
    {
        //[AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)] 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            return View(model);
        }
    }
}