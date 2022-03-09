using System.Collections.Generic;

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
        public string Name;
        public Role UserRole;
        public List<EventModel> AvailableEvents;
    }
}