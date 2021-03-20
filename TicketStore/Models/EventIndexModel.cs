using System.Collections.Generic;
using TicketStore.Data.Models;

namespace TicketStore.Models
{
    public class EventIndexModel
    {
        public IEnumerable<EventIndexListingModel> Events { get; set; }
    }
}