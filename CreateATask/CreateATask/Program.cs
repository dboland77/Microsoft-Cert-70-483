using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreateATask
{
    class Program
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
        }

        static void Main(string[] args)
        {
            // Task newTask = new Task(() => DoWork());
            // newTask.Start();
            // newTask.Wait();
            Task newTask = Task.Run(() => DoWork());
            newTask.Wait();
        
        }

    }
}
