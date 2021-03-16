using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Required] public string Name { get; set; }
        
        public virtual Filling Filling { get; set; }
        public virtual TicketsInfo TicketsInfo { get; set; }
    }
}