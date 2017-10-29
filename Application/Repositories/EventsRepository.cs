using System;
using System.Collections.Generic;
using System.Linq;
using Application.Models;

namespace Application.Repositories
{
    public class EventsRepository : IEventsRepository
    {
        private ApplicationContext context;
        
        public EventsRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return context.Events.ToList();
        }
    }
}
