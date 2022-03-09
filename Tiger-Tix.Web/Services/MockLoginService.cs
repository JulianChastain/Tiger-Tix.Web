using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class MockLoginService : ILoginService
    {
        public UserViewModel LoginWithCredentials(string name, string password)
        {
            if (name == "julian" && password == "password")
                return new UserViewModel ()
                {
                    Name = name,
                    UserRole = Role.Student
                };
            return new UserViewModel();
        }
    }
}