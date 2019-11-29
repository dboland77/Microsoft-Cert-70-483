using System;
using System.Threading;

namespace ThreadsAndLambdaExpressions_L1._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() =>
           {
               Console.WriteLine("Hello from the thread");
               Thread.Sleep(1000);
           });

            thread.Start();
            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }

        
    }
}
