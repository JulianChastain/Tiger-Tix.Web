using System;
using System.Collections.Generic;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class MockEventRepository : IEventRepository
    {
        private List<EventModel> _events;

        public MockEventRepository()
        {
            _events = new List<EventModel>
            {
                new()
                {
                     Name = "Blood Drive",
                     Time = DateTime.Now,
                     RemainingTickets = 42
                },
                new()
                {
                     Name = "Football Game",
                     Time = DateTime.Now,
                     RemainingTickets = 69
                },
                new()
                {
                     Name = "Hendrix Center Event",
                     Time = DateTime.Now,
                     RemainingTickets = 314
                },
            };
            
        }
        public List<EventModel> Events()
        {
            return _events;
        }
    }
}