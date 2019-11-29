using System;
using System.Threading;

namespace ThreadSyncUsingJoin_L1._25
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread Starting");
                Thread.Sleep(2000);
                Console.WriteLine("Thread Done.");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join(); // joining the thread holds this process until the thread joined completes
            // this means that the line below will now not execute until the thread has finished processing. 
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
