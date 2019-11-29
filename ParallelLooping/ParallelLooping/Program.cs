using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ParallelLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();
            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 200)
                    loopState.Stop();
                WorkOnItem(items[i]);
            }

            );
            
        }
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }
    }
}
