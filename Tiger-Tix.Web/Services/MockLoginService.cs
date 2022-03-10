using Microsoft.AspNetCore.Authorization.Infrastructure;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class MockLoginService : ILoginService
    {
        public UserViewModel LoginWithCredentials(string name, string password)
        {
            if (name == "julian")
                return new UserViewModel ()
                {
                    Name = name,
                    UserRole = Role.Administrator
                };
            if (name == "charlie" || name == "spencer")
                return new UserViewModel()
                {
                    Name = name,
                    UserRole = Role.Student
                };
            return new UserViewModel();
        }
    }
}