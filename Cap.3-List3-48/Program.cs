using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_48
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }

            EventLog log = new EventLog();
            log.Source = "MySource";
            log.WriteEntry("Log event!");
        }
    }
}

/*
 * Writing data to the event log
 * */
