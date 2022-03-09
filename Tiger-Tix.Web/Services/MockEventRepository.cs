using System;
using System.Collections.Generic;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class MockEventRepository : IEventRepository
    {
        public List<EventModel> Events()
        {
            return new List<EventModel>
            {
                new EventModel()
                {
                    Name = "Blood Drive",
                    Time = DateTime.Now,
                    RemainingTickets = 42
                },
                new EventModel()
                {
                    Name = "Football Game",
                    Time = DateTime.Now,
                    RemainingTickets = 69
                },
                new EventModel()
                {
                    Name = "Hendrix Center Event",
                    Time = DateTime.Now,
                    RemainingTickets = 314
                },
            };
        }
    }
}