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
            optionsBuilder.UseSqlServer(_configuration["ConnectionString:DefaultConnection"]);
        }
        
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

        public void AddUser(UserViewModel user)
        {
            return;
        }
        
    }
}