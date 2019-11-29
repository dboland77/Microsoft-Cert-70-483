using System;
using System.Threading;

namespace ParameterisedThreadStart
{
    class Program
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }
        static void Main(string[] args)
        {
            //ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            //Thread thread = new Thread(ps);
            //thread.Start(27);

            // We can also do the above with a lambda expression

            Thread thread = new Thread((data) =>
            {
                WorkOnData(data);
            });

            thread.Start(99);
        
        }
    }
}
