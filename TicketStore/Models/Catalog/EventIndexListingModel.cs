using TicketStore.Data.Models;

namespace TicketStore.Models.Catalog
{
    public class EventIndexListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Filling Filling { get; set; }
        public TicketsInfos TicketsInfos { get; set; }
    }
}