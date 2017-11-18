using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_45
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug

            Debug.WriteLine("Starting application");
            Debug.Indent(); //aplica identação no texto debug

            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "I is greater than 0");

            /*
             * Using TraceSource class
             * */

            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.TraceInformation("Tracing application");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });

            traceSource.Flush();
            traceSource.Close();

            //configuring TraceListener to write in a text file

            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener text = new TextWriterTraceListener(outputFile);

            TraceSource trace = new TraceSource("trace", SourceLevels.All);
            trace.Listeners.Clear();
            trace.Listeners.Add(text);
            trace.TraceInformation("Trace output");
            trace.Flush();
            trace.Close();
        }
    }
}
