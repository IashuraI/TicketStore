using Microsoft.EntityFrameworkCore;
using TicketStore.Data.Models;

namespace TicketStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options){}
        

        public DbSet<Event> Events { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketsInfo> TicketsInfos { get; set; }
        public DbSet<Filling> Fillings { get; set; }
    }
}