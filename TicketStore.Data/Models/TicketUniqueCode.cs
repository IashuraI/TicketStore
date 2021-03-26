using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class TicketUniqueCode
    {
        public int Id { get; set; }
        [Required]public string UniqueCode { get; set; }
        [Required]public bool InStock { get; set; }
        [Required]public Ticket Ticket { get; set; }
    }
}