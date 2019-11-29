using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 10.5;
            int integer = 2;

            num = num + integer;
            Console.WriteLine("Implicit Cast: " + num);

            num = (double) 7 / integer;
            Console.WriteLine("Explicit Cast: " + num);

            //ASCII Equivalent
            char letter = (char)65;
            Console.WriteLine("Cast integer: " + letter);

            //Cast a char type to an integer and then display ASCII
            int ascii = (int)'A';
            Console.WriteLine("Cast letter: " + ascii);
            Console.ReadKey();


            //double sum = (double) 7 / 2;
              //  Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
