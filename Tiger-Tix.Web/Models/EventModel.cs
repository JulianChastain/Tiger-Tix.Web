using System;

namespace Tiger_Tix.Web.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int RemainingTickets { get; set; }

        public override string ToString()
        {
            return $"{Name} at {Time} with {RemainingTickets} tickets left";
        }
    }
}