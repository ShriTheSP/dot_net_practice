using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ESS_input
{
    public class Scheduler
    {
        private List<Event> events;
        public Scheduler()
        {
            events = new List<Event>();
        }

        public void AddEventInput()
        {
            Event newevent = new Event();
            Console.WriteLine("Enter the id of event :");
            newevent.EventID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of event :");
            newevent.EventName =Console.ReadLine();
            Console.WriteLine("Enter the Description of event :");
            newevent.Description = Console.ReadLine();
            Console.WriteLine("Enter the start time of event :");
            newevent.StartTime =Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the end time of event :");
            newevent.EndTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(Add_Event(newevent));

        }
        public bool Add_Event(Event newevent)
        {
            if (CheckOverlap(newevent.StartTime, newevent.EndTime))
            {
                Console.WriteLine("Event overlaps.....!");
                return false;
            }

            events.Add(newevent);
            Console.WriteLine("Event Added Successfully...");
            return true;
        }

        public bool CheckOverlap(DateTime newstarttime, DateTime newendtime, int excludeid = -1)
        {
            return events.Any(e => e.EventID != excludeid && (newstarttime < e.EndTime && newendtime > e.StartTime));

        }

        public bool RemoveEvent()
        {
            Console.WriteLine("Enter the Id of event to be removed : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Event eventtoremove = events.FirstOrDefault(e => e.EventID == id);
            if (eventtoremove != null)
            {
                events.Remove(eventtoremove);
                Console.WriteLine("Event Removed Successfully...");
                return true;
            }
            Console.WriteLine("Event not found ");
            return false;
        }

        public bool UpdateEvent()
        {
            Console.WriteLine("Enter the id of event to be updated : ");
            int id = Convert.ToInt32(Console.ReadLine());
            var eventtoupdate = events.FirstOrDefault(e => e.EventID ==id);
            if (eventtoupdate != null)
            {
                AddEventInput();
                Console.WriteLine("Event Updated Successfully...");
                return true;
            }
            else
            {
                Console.WriteLine("No Such Event Found....!");
                return false;
            }

        }

        public void ListEventsByDate()
        {
            Console.WriteLine("Enter the date in (YYYY-M-D) format :");
            DateTime listdate=Convert.ToDateTime(Console.ReadLine());
            List<Event> eventslist = events.Where(e => e.StartTime.Date == listdate.Date).ToList();
            foreach (var e in eventslist)
            {
                Console.WriteLine($"Event ID : {e.EventID},\nName : {e.EventName},\nDescription : {e.Description},\nStarttime : {e.StartTime},\nEnd Time : {e.EndTime}");
                Console.WriteLine("--------------------------------------");
            }
        }

        public void ListEventById()
        {
            Console.WriteLine("Enter the Event ID  :");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Event> eventslist = events.Where(e => e.EventID == id).ToList();
            foreach (var e in eventslist)
            {
                Console.WriteLine($"Event ID : {e.EventID},\nName : {e.EventName},\nDescription : {e.Description},\nStarttime : {e.StartTime},\nEnd Time : {e.EndTime}");
                Console.WriteLine("--------------------------------------");
            }

        }

        public void ListAllEvents()
        {
            List<Event> eventslist = events.ToList();
            foreach (var e in eventslist)
            {
                Console.WriteLine($"Event ID : {e.EventID},\nName : {e.EventName},\nDescription : {e.Description},\nStarttime : {e.StartTime},\nEnd Time : {e.EndTime}");
                Console.WriteLine("--------------------------------------");
            }

        }

    }
}
