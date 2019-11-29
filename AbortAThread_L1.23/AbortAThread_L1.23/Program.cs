using System;
using System.Threading;

namespace AbortAThread_L1._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tickThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            }
            );

            tickThread.Start();

            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickThread.Abort();

            //This is a terrible way to stop the thread because it leaves the program 
            // in an ambiguous state and throws an exception. Better to use a shared flag - next lesson
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
