using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class LoginService : DbContext, ILoginService
    {
        public DbSet<UserViewModel> Users { get; set; }
        private readonly IConfiguration _configuration;
        
        public LoginService(IConfiguration config)
        {
            _configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connection = _configuration["ConnectionString:DefaultConnection"];
            optionsBuilder.UseSqlServer(connection);
        }

        public UserViewModel LoginWithCredentials(LoginInfoViewModel userInfo)
        {
            var possible_match = from user in Users where user.Email == userInfo.Email select user;
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

        public void AddUser(UserViewModel user)
        {
            Users.Add(user);
            SaveChanges();
        }
        
    }
}