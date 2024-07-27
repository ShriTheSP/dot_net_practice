using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Scheduler scheduler = new Scheduler();
            int choice;
            Console.WriteLine("---Event Scheduling System ---");
            do
            {
                Console.WriteLine("1.ADD Event \n2.REMOVE Event \n3.UPDATE Event \n4.LIST Events by date \n5.LIST ALL Events \n6.LIST Event by Id \n7.EXIT.");
                Console.WriteLine("Enter your option");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        scheduler.AddEventInput();
                        break;
                    case 2:
                        scheduler.RemoveEvent();
                        break;
                    case 3:
                        scheduler.UpdateEvent();
                        break;
                    case 4:
                        scheduler.ListEventsByDate();
                        break;
                    case 5:
                        scheduler.ListAllEvents();
                        break;
                    case 6:
                        scheduler.ListEventById();
                        break;
                    case 7:
                        Console.WriteLine("Thank you ...");
                        return;

                }
            } while (choice != 6);
        }
    }
}










