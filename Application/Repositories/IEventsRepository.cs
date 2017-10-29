using System;
using System.Collections.Generic;
using Application.Models;

namespace Application.Repositories
{
    public interface IEventsRepository
    {
        IEnumerable<Event> GetAllEvents();
    }
}
