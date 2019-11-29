using System;
using System.Threading;
//Threads are a lower level of abstraction than tasks and they run in the foreground
// Threads represent a process running within the operating system

namespace Creating_Threads_L1._18
{
    class Program
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            //Thread thread = new Thread(ThreadHello);
            //thread.Start();

            //Older versions of .NET required you to create a ThreadStart delegate to specify
            // the method to be executed by the thread. This is shown below but now used now

            ThreadStart ts = new ThreadStart(ThreadHello);
            Thread thread = new Thread(ts);
            thread.Start();
        }
    }
}
