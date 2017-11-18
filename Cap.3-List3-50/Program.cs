using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_50
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog log = new EventLog("NewEventLog");

            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index: " + last.Index);
            Console.WriteLine("Source: " + last.Source);
            Console.WriteLine("Type: " + last.EntryType);
            Console.WriteLine("Time: " + last.TimeGenerated);
            Console.WriteLine("Message: " + last.Message);
        }
    }
}

/*
 * Reading data from the event log
 * */
