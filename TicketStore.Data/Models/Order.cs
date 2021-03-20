using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        [Required]
        public DateTime CreateDate { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<Ticket>  Tickets{ get; set; }
        public Order()
        {
            Tickets = new List<Ticket>();
        }
    }
}