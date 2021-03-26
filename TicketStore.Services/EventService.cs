using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TicketStore.Data;
using TicketStore.Data.Models;

namespace TicketStore.Services
{
    public class EventService : IEvent
    {
        private StoreContext context;

        public EventService(StoreContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Event> GetAllEvents()
        {
            return context.Events
                .Include(events => events.Filling)
                .Include(events => events.TicketsInfo);
        }

        public IEnumerable<Event> GetAllEventsAsNoTracking()
        {
            return context.Events
                .Include(events => events.Filling)
                .Include(events => events.TicketsInfo)
                .AsNoTracking();
        }

        public void Add(Event newEvent)
        {
            context.Events.Add(newEvent);
            context.SaveChanges();
        }

        public Event GetById(int id)
        {
            return GetAllEvents().FirstOrDefault(Event => Event.EventId == id);
        }

        public string Name(int id)
        {
            return GetById(id).Name;
        }
    }
}