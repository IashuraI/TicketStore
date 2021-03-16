using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System.Runtime.CompilerServices;

namespace TicketStore.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] 
        public string Email { get; set; }
        
        [Required] 
        [StringLength(20, ErrorMessage = "Limit customer name to 20 characters.")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(20, ErrorMessage = "Limit customer surname to 20 characters.")]
        public string Surname { get; set; }
        
        [Required] 
        [DateTimeRangeValidator("1921-01-01T00:00:00", "2021-01-01T00:00:00")]
        public DateTime DayOfBirthday { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}