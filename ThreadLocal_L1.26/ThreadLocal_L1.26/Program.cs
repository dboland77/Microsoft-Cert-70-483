using System;
using System.Threading;

namespace ThreadLocal_L1._26
{
    class Program
    {
        // If we need to initialise local data for each thread we use the ThreadLocal class
        // When an instance of this class is created it creates a delegate to the code that will 
        // initialise attributes of that thread
        // In this case the RandomNumberGenerator will have the same "random" behaviour for each task
        
        public static ThreadLocal<Random> RandomGenerator =
            new ThreadLocal<Random> (() =>
          {
              return new Random(2);
          });


        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("t1: {0}", RandomGenerator.Value.Next(10));
                    Thread.Sleep(5000);
                }
            });

            Thread t2 = new Thread(() =>
           {
               for (int i = 0; i < 5; i++)
               {
                   Console.WriteLine("t2: {0}", RandomGenerator.Value.Next(10));
                   Thread.Sleep(5000);
               }
           });

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
