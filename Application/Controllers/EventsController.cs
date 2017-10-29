using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private IEventsRepository eventsRepository;
        private ILogger<EventsController> logger;
        
        public EventsController(
            IEventsRepository eventsRepository,
            ILogger<EventsController> logger)
        {
            this.eventsRepository = eventsRepository;
            this.logger = logger;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try{
                return Ok(eventsRepository.GetAllEvents());
            }catch(Exception err){
                logger.LogError($"Failed to get events in events controller: {err.Message}");
                return Ok(Enumerable.Empty<Event>());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Event theEvent)
        {
            return Ok(true);
        }
    }
}
