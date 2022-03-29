using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public interface ILoginService
    {
        IEnumerable<UserViewModel> Users();

        UserViewModel LoginWithCredentials(LoginInfoViewModel userInfo)
        {
            IEnumerable<UserViewModel> possible_match = from user in Users() where user.Email == userInfo.Email select user;
            if (possible_match.Any())
            {
                foreach (var u in possible_match)
                {
                    if (BCrypt.Net.BCrypt.Verify(userInfo.Password, u.Passhash))
                        return u;
                }

                var val = new UserViewModel();
                val.UserRole = Role.InvalidPassword;
                return val;

            }
            return new UserViewModel();
        }
        void AddUser(UserViewModel user);
    }
}