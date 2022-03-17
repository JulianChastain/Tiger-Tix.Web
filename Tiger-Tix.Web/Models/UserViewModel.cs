using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Tiger_Tix.Web.Models
{
    public enum Role
    {
        InvalidLogin,
        Student,
        Guest,
        Administrator
    }
    public class UserViewModel
    {
        public UserViewModel(LoginInfoViewModel u)
        {
            Name = u.Username;
            UserRole = Role.Guest;
        }
        
        public UserViewModel(){}
        public string Id { get; set; }
        public string Name;
        public Role UserRole;
        public List<EventModel> AvailableEvents;
        public List<EventModel> BoughtEvents;
    }
}