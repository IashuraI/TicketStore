using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class TicketsInfo
    {
        public int TicketsInfoId { get; set; }
        [Required]public DateTime ExpiredTime { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}