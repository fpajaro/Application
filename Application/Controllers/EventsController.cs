using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private ApplicationContext context;
        
        public EventsController(ApplicationContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public ICollection<Event> Get()
        {
            return context.Events.ToList();
        }
    }
}
