using System;
using System.Collections;
using System.Collections.Generic;
using TicketStore.Data.Models;

namespace TicketStore.Data
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetAllCustomersAsNoTracking();
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllOrdersAsNoTracking();
        Customer GetById(int id);

        void Add(Customer newCustomer);
        string Email(int id);
        string Name(int id);
        string Surname(int id);
        DateTime DayOfBirthday(int id);
    }
}