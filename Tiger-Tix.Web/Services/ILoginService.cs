using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public interface ILoginService
    {
        UserViewModel LoginWithCredentials(string name, string password);
        void AddUser(UserViewModel user);
    }
}