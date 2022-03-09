using Microsoft.AspNetCore.Mvc;
using Tiger_Tix.Web.Models;
using Tiger_Tix.Web.Services;

namespace Tiger_Tix.Web
{
    public class AppController : Controller
    {
        private ILoginService LoginService;
        private IEventRepository Events;
        public AppController(ILoginService loginService, IEventRepository events)
        {
            LoginService = loginService;
            Events = events;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginInfoViewModel model)
        {
            UserViewModel UserInfo = LoginService.LoginWithCredentials(model.UserName, model.PassWord);
            UserInfo.AvailableEvents = Events.Events();
            return View("SplashPage", UserInfo);
        }
    }
}