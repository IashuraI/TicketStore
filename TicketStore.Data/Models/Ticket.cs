using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public decimal Price { get; set; }
        [Required] public string UniqueCode { get; set; }
        [Required] public int AmountOfTickets { get; set; }
        
        public virtual ICollection<Order>  Orders{ get; set; }
        public Ticket()
        {
            Orders = new List<Order>();
        }
    }
}