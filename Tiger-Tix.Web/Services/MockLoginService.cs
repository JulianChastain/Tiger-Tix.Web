using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class MockLoginService : ILoginService
    {
        private List<UserViewModel> _users;
        public MockLoginService()
        {
            _users = new List<UserViewModel>
            {
                new()
                {
                    Name = "julian",
                    UserRole = Role.Administrator,
                    Passhash = BCrypt.Net.BCrypt.HashPassword("password")
                },

                new()
                {
                    Name = "spencer",
                    UserRole = Role.Student,
                    Passhash = BCrypt.Net.BCrypt.HashPassword("password")
                },
                new()
                {
                    Name = "charlie",
                    UserRole = Role.Student,
                    Passhash = BCrypt.Net.BCrypt.HashPassword("password")
                }
            };
        }

        public IEnumerable<UserViewModel> Users()
        {
            return _users;
        }

        public void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }
    }
}