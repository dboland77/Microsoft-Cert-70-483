using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace Parallel_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

            */
            //Generates a range of numbers from 0 to 500, Enumerate is in System.Linq
           /* var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });
            Console.WriteLine("Finished processing, press a key to end.");
            Console.ReadKey();
            */

            var items = Enumerable.Range(0, 500).ToArray();
            //We can use Parallel.For to parallelise the execution of a for loop which is governed by a control variable
            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(items[i]);
            });
            
                Console.WriteLine("Finished processing, press a key to end.");
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }
    }
}
