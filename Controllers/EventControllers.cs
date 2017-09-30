using System.Collections.Generic;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [Route("api/[controller]")]
    public class EventController
    {
        private readonly IEventService _EventService;
        public EventController(IEventService eventService)
        {
            this._EventService = eventService;
        }
        
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return this._EventService.GetEvents();
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return this._EventService.GetEventById(id);
        }

        [HttpGet("{title}")]
        public Event Get(string title)
        {
            return this._EventService.GetEventByName(title);
        }
    }
}