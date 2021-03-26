using System.Collections.Generic;

namespace TicketStore.Models.Catalog
{
    public class EventIndexModel
    {
        public IEnumerable<EventIndexListingModel> Events { get; set; }
    }
}