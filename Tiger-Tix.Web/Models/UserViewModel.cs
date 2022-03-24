using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Tiger_Tix.Web.Models
{
    public enum Role
    {
        InvalidLogin,
        InvalidPassword,
        Student,
        Guest,
        Administrator
    }
    public class UserViewModel
    {
        public UserViewModel(LoginInfoViewModel u)
        {
            Email = u.Email;
            UserRole = Role.InvalidLogin;
        }
        
        public UserViewModel(){}
        public string Id { get; set; }
        public string Name;
        public string Email;
        public string Passhash;
        public Role UserRole;
        public List<EventModel> AvailableEvents;
        public List<EventModel> BoughtEvents;
    }
}