using System.Collections;
using System.Collections.Generic;
using TicketStore.Data.Models;

namespace TicketStore.Data
{
    public interface IEvent
    {
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetAllEventsAsNoTracking();

        void Add(Event newEvent);
        
        Event GetById(int id);
        string Name(int id);
    }
}