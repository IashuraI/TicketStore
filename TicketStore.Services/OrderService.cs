using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TicketStore.Data;
using TicketStore.Data.Models;

namespace TicketStore.Services
{
    public class OrderService : IOrder
    {
        private StoreContext context;
        
        public OrderService(StoreContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Order> GetAllOrders()
        {
            return context.Orders
                .Include(orders => orders.Tickets);
        }

        public IEnumerable<Order> GetAllOrdersAsNoTracking()
        {
            return context.Orders
                .Include(orders => orders.Tickets).AsNoTracking();
        }

        public void Add(Order newOrder)
        {
            context.Orders.Add(newOrder);
            context.SaveChanges();
        }

        public Order GetById(int id)
        {
            return GetAllOrders().FirstOrDefault(order => order.OrderId == id);
        }

        public DateTime CreateDate(int id)
        {
            return GetById(id).CreateDate;
        }
    }
}