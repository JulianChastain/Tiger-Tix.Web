using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            Passhash = BCrypt.Net.BCrypt.HashPassword(u.Password);
            UserRole = Role.InvalidLogin;
        }
        
        public UserViewModel(){}
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerat‌ed(System.ComponentM‌​odel.DataAnnotations‌​.Schema.DatabaseGeneratedOp‌​tion.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Passhash { get; set; }
        public Role UserRole { get; set; }
        public List<EventModel> AvailableEvents { get; set; }
        public List<EventModel> BoughtEvents { get; set; }
    }
}