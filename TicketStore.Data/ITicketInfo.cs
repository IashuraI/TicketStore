using System;
using System.Collections.Generic;
using TicketStore.Data.Models;

namespace TicketStore.Data
{
    public interface ITicketInfo
    {
        IEnumerable<TicketsInfos> GetAllTicketInfo();
        IEnumerable<TicketsInfos> GetAllTicketInfoAsNoTracking();

        void Add(TicketsInfos newTicketsInfos);
        
        TicketsInfos GetById(int id);
        DateTime ExpiredTime(int id);
    }
}