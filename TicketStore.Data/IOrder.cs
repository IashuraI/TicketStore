using System;
using System.Collections.Generic;
using TicketStore.Data.Models;

namespace TicketStore.Data
{
    public interface IOrder
    {
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllOrdersAsNoTracking();

        void Add(Order newOrder);
        
        Order GetById(int id);
        public DateTime CreateDate(int id);
    }
}