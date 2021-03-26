using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TicketStore.Data;
using TicketStore.Data.Models;
using TicketStore.Models;
using TicketStore.Models.Catalog;

namespace TicketStore.Controllers
{
    public class CatalogController : Controller
    {
        private IEvent _event;
        public CatalogController(IEvent _event)
        {
            this._event = _event;
        }

        public IActionResult Index()
        {
            var events = _event.GetAllEventsAsNoTracking();
            
            var listingResult = events.Select(result => new EventIndexListingModel
            {
                Id = result.EventId,
                Name = result.Name,
                Filling = result.Filling,
                TicketsInfos = result.TicketsInfos
            });

            var model = new EventIndexModel()
            {
                Events = listingResult
            };
            
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var eEvent = _event.GetById(id);
            
            var model = new EventDetailModel
            {
                Id = id,
                Name = eEvent.Name,
                ExpiredTime = eEvent.TicketsInfos.ExpiredTime,
                Filling = eEvent.Filling,
            };
            
            return View(model);
        }
    }
}