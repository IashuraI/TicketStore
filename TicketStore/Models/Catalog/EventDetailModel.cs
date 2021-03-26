using System;
using TicketStore.Data.Models;

namespace TicketStore.Models.Catalog
{
    public class EventDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Filling Filling { get; set; }
        public DateTime ExpiredTime { get; set; }
        public bool AnyTickets { get; set; }
    }
}