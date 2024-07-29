using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace event_assignment
{
    public class Event
    {
        public int Eventid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Startime { get; set; }
        public DateTime EndTime { get; set; }


        public Event(int eventid, string title, string description, DateTime starttime, DateTime endtime)
        {
            Eventid = eventid;
            Title = title;
            Description = description;
            Startime = starttime;
            EndTime = endtime;

        }
    }
    public class Scheduler
    {
        private List<Event> events = new List<Event>();
        public Scheduler()
        {
            events = new List<Event>();
        }
        public bool AddEvent(Event newEvent)
        {
            if (CheckOverlap(newEvent.Startime, newEvent.EndTime))
            {
                Console.WriteLine("Can't add Event as it  Overlaps ...........!");
                return false;
            }
            events.Add(newEvent);
            Console.WriteLine("Event added successfully...");
            return true;
        }

        private bool CheckOverlap(DateTime newStartTime, DateTime newEndTime, int excludeEventId = -1)
        {
            return events.Any(e => e.Eventid != excludeEventId && (newStartTime < e.EndTime && newEndTime > e.Startime));
        }

        public bool RemoveEvent(int eventid)
        {
            var event_to_remove = events.FirstOrDefault(e => e.Eventid == eventid);
            if (event_to_remove != null)
            {
                events.Remove(event_to_remove);
                Console.WriteLine("event removed successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("event not found...!");
                return false;
            }
        }

        public bool UpdateEvent(int eventid, string title, string description, DateTime starttime, DateTime endtime)
        {
            var event_to_update = events.FirstOrDefault(e => e.Eventid == eventid);
            if (event_to_update != null)
            {
                if (CheckOverlap(starttime, endtime, eventid))
                {
                    Console.WriteLine("Cant update Event,it overlaps .....!");
                    return false;
                }
                event_to_update.Title = title;
                event_to_update.Description = description;
                event_to_update.Startime = starttime;
                event_to_update.EndTime = endtime;
                Console.WriteLine("event updated successfully");
                return true;


            }
            else
            {
                Console.WriteLine("event not found");
                return false;

            }
        }

        public List<Event> listeventbyid(int id)
        {
            return events.Where(e => e.Eventid == id).ToList();
        }

        public List<Event> listeventbydate(DateTime date)
        {
            return events.Where(e => e.Startime.Date == date).ToList();

        }

        public List<Event> listallevents()
        {
            return events.ToList();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Scheduler scheduler = new Scheduler();
            scheduler.AddEvent(new Event(1,"meeting 1","team meeting with old and new members",new DateTime(2024 ,7,25,6,0,0),new DateTime(2024,7,25,7,0,0)));
            scheduler.AddEvent(new Event(2, "meeting 2", "team meeting with old and new members", new DateTime(2024, 7, 25, 7, 0, 0), new DateTime(2024, 7, 25, 8, 0, 0)));
            scheduler.AddEvent(new Event(3, "meeting 3", "team meeting with old and new members", new DateTime(2024, 7, 25, 6, 0, 0), new DateTime(2024, 7, 25, 7, 0, 0)));
            scheduler.RemoveEvent(1);
            scheduler.AddEvent(new Event(3,"meeting","team meeting with old and new members", new DateTime(2024, 7, 25, 6, 0, 0), new DateTime(2024, 7, 25, 7, 0, 0)));
            scheduler.UpdateEvent(3, "Updated event 3", "team work with old and new members", new DateTime(2024, 7, 25, 6, 0, 0), new DateTime(2024, 7, 25, 7, 0, 0));
            Console.WriteLine("*************************** Events listed by id **********************************");
            var listid=scheduler.listeventbyid(3);
            foreach (var e in listid) 
            {

                Console.WriteLine($"  Event ID: {e.Eventid}, \n  Title: {e.Title}, \n  Description: {e.Description}, \n  StartTime: {e.Startime}, \n  EndTime: {e.EndTime} |");
                Console.WriteLine(" -------------------------------------------------");

            }
            Console.WriteLine("*************************** Events listed by date**********************************");
            var listdate= scheduler.listeventbydate(new DateTime( 2024 ,7 ,25));
            foreach (var e in listdate) 
            {
             
                Console.WriteLine($"  Event ID: {e.Eventid}, \n  Title: {e.Title}, \n  Description: {e.Description}, \n  StartTime: {e.Startime}, \n  EndTime: {e.EndTime} |");
                Console.WriteLine(" -------------------------------------------------");

            }
            Console.WriteLine("*************************** All events list**********************************");
            var listall = scheduler.listallevents();
            foreach (var e in listall)
            {

                Console.WriteLine($"  Event ID: {e.Eventid}, \n  Title: {e.Title}, \n  Description: {e.Description}, \n  StartTime: {e.Startime}, \n  EndTime: {e.EndTime} |");
                Console.WriteLine(" -------------------------------------------------");

            }


        }
    }
}
