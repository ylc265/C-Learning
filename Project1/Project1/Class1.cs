using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {
        static void Main()
        {
//            FileAsyncWriter writer = new FileAsyncWriter(@"c:\Users\daniche\file1.txt");
//            writer.Write("HI This is me");
            ManualResetEvent[] events = new ManualResetEvent[3];
            for (int i = 0; i < events.Length; i++)
            {
                events[i] = new ManualResetEvent(false);
                FileAsyncWriter writer = new FileAsyncWriter(@"C:\Users\daniche\file" + i + ".txt", events[i]);
                Thread t = new Thread(writer.Write);
                t.Start("Hello This is Arnold");   
            }
            WaitHandle.WaitAll(events);
            Console.WriteLine("Done");
        }
    }
    
}
