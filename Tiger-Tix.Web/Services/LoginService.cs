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

        IEnumerable<UserViewModel> ILoginService.Users()
        {
            return Users;
        }

        public void AddUser(UserViewModel user)
        {
            Users.Add(user);
        }
        
    }
}