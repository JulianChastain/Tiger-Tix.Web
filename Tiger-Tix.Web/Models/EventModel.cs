using System;

namespace Tiger_Tix.Web.Models
{
    public class EventModel
    {
        private string Name { get; set; }
        private DateTime Time { get; set; }
        private int RemainingTickets { get; set; }
    }
}