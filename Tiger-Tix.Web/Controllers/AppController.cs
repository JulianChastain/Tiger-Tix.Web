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
            ViewBag.error = false;
            ViewBag.noaccount = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginInfoViewModel model)
        {
            if (model.Password == null || model.Password == "")
                model.Password = "obviously_wrong_password_value";
            
            UserViewModel UserInfo = LoginService.LoginWithCredentials(model);
            if (UserInfo.UserRole != Role.InvalidLogin && UserInfo.UserRole != Role.InvalidPassword)
            {
                ViewBag.AvailableEvents = Events.Events();
                return View("SplashPage", UserInfo);
            }

            ViewBag.error = UserInfo.UserRole == Role.InvalidPassword;
            ViewBag.noaccount = UserInfo.UserRole == Role.InvalidLogin;
            return View("index");
        }

        public IActionResult CreateAccount()
        {
            return View();
        }
        
        
        [HttpPost]
        public IActionResult CreateAccount(UserViewModel newUser)
        {
            ViewBag.AvailableEvents = Events.Events();
            newUser.Passhash = BCrypt.Net.BCrypt.HashPassword(newUser.Passhash);
            LoginService.AddUser(newUser);
            return View("SplashPage", newUser);
        }
    }
}
