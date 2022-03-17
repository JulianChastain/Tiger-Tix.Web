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
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginInfoViewModel model)
        {
            UserViewModel UserInfo = LoginService.LoginWithCredentials(model.Username, model.Password);
            UserInfo.AvailableEvents = Events.Events();
            return View("SplashPage", UserInfo);
        }

        public IActionResult CreateAccount()
        {
            return View();
        }
        
        
        [HttpPost]
        public IActionResult CreateAccount(LoginInfoViewModel loginInfo)
        {
            var newUser = new UserViewModel(loginInfo);
            LoginService.AddUser(newUser);
            return View("SplashPage", newUser);
        }
    }
}