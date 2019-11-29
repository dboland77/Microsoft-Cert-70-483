using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // The Task Parallel library lives in here


namespace Microsoft_Cert_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = x => x * x; // so Func<int,int> is an Action delegate - takes an int gives an int
            // the => is a lambda expression this converts it to an action delegate
            Console.WriteLine(square(5));
           

            //Expression lambdas can also be converted to expression tree types as below:
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            //Output
            // x => (x*x)

            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

            //Microsft Cert Skill 1.1: Implement multithreading and asynchronous processing

            //1. The Task Parallel library
            // A task is a unit of work to be performed. The work will be described by a method or a lamda expression or similar. 
            // We can perform a task concurrently with other tasks

            // Task Parallel Library (TPL) provides a range of resources that allow you to use tasks in an application. 
            // The Task.Parallel class in the library provides three methods that can be used to create applications that contain tasks that 
            // execute in parallel
            
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
        }
    }
}
