using System.Collections.Generic;
using System.Linq;
using Model;

namespace BusinessLogic.Services
{
    public interface IEventService
    {
        IEnumerable<Event> GetEvents();
        Event GetEventById(int id);

        Event GetEventByName(string name);
    }
    public class EventService : IEventService
    {
        public Event GetEventById(int id)
        {
            return EventList.EventLists()
                             .FirstOrDefault(x => x.Id == id);
        }

        public Event GetEventByName(string name)
        {
            return EventList.EventLists().FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Event> GetEvents()
        {
            return EventList.EventLists();
        }
    }

    public static class EventList
    {
        public static IList<Event> EventLists()
        {
            return new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Wedding",
                    Price = 350.00m,
                },
                new Event
                {
                    Id = 2,
                    Name = "Send-Off",
                    Price = 250m,
                },
                 new Event
                {
                    Id = 3,
                    Name = "Birthdays",
                    Price = 250m,
                },
                 new Event
                {
                    Id = 4,
                    Name = "Communion/Confirmation",
                    Price = 250m,
                },
                 new Event
                {
                    Id = 5,
                    Name = "Meeting",
                    Price = 250m,
                },
                 new Event
                {
                    Id = 6,
                    Name = "School Programs",
                    Price = 250m,
                },
                 new Event
                {
                    Id = 7,
                    Name = "Other",
                    Price = 250m,
                },
            };
        }
    }
}