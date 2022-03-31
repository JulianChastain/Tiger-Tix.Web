using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public interface ILoginService
    {
        UserViewModel LoginWithCredentials(LoginInfoViewModel userInfo);
        void AddUser(UserViewModel user);
    }
}