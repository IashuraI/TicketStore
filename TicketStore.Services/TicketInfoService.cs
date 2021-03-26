using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TicketStore.Data;
using TicketStore.Data.Models;

namespace TicketStore.Services
{
    public class TicketInfoService : ITicketInfo
    {
        private StoreContext context;
        
        public TicketInfoService(StoreContext context)
        {
            this.context = context;
        }
        public IEnumerable<TicketsInfos> GetAllTicketInfo()
        {
            return context.TicketsInfos;
        }

        public IEnumerable<TicketsInfos> GetAllTicketInfoAsNoTracking()
        {
            return context.TicketsInfos.AsNoTracking();
        }

        public void Add(TicketsInfos newTicketInfo)
        {
            context.TicketsInfos.Add(newTicketInfo);
            context.SaveChanges();
        }

        public TicketsInfos GetById(int id)
        {
            return GetAllTicketInfo().FirstOrDefault(info => info.TicketsInfosId == id);
        }

        public DateTime ExpiredTime(int id)
        {
            return GetById(id).ExpiredTime;
        }
    }
}