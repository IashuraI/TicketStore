using System.ComponentModel.DataAnnotations;

namespace TicketStore.Data.Models
{
    public class Filling
    {
        public int FillingId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}