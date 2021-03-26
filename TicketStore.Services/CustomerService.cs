using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TicketStore.Data;
using TicketStore.Data.Models;

namespace TicketStore.Services
{
    public class CustomerService : ICustomer
    {
        private StoreContext context;

        public CustomerService(StoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customers
                .Include(customer => customer.Orders)
                .Include(customer => customer.DayOfBirthday);
        }

        public IEnumerable<Customer> GetAllCustomersAsNoTracking()
        {
            return context.Customers
                .Include(customer => customer.Orders)
                .Include(customer => customer.DayOfBirthday)
                .AsNoTracking();
        }
       
        public Customer GetById(int id)
        {
            return context.Customers.FirstOrDefault(customer => customer.Id == id);
        }

        public void Add(Customer newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public string Email(int id)
        {
            return GetById(id).Email;
        }

        public string Name(int id)
        {
            return GetById(id).Name;
        }

        public string Surname(int id)
        {
            return GetById(id).Surname;
        }

        public DateTime DayOfBirthday(int id)
        {
            return GetById(id).DayOfBirthday;
        }
    }
}