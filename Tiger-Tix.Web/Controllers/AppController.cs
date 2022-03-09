using Microsoft.AspNetCore.Mvc;
using Tiger_Tix.Web.Models;
using Tiger_Tix.Web.Services;

namespace Tiger_Tix.Web
{
    public class AppController : Controller
    {
        private ILoginService LoginService;
        public AppController(ILoginService loginService)
        {
            LoginService = loginService;
        }
        //[AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)] 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginInfoViewModel model)
        {
            return View("SplashPage",LoginService.LoginWithCredentials(model.UserName, model.PassWord));
        }
    }
}