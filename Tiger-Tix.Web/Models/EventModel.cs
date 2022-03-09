using System;

namespace Tiger_Tix.Web.Models
{
    public class EventModel
    {
        public string Name;
        public DateTime Time;
        public int RemainingTickets;

        public override string ToString()
        {
            return $"{Name} at {Time} with {RemainingTickets} tickets left";
        }
    }
}