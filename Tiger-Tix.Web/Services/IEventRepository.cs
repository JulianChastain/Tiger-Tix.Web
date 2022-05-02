using System.Collections.Generic;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public interface IEventRepository
    {
        List<EventModel> Events();
        void AddEvent(EventModel event_to_add);
    }
}