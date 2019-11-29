using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrates base and overloaded constructors
            Daughter anna = new Daughter();
            Son brad = new Son();
            Son carl = new Son(100);
            Console.ReadKey();
        }
    }
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Called");
        }

        //Overloaded constructor
        public Parent(int num)
        {
            Console.WriteLine("Parent+ Called:" + num);
        }
    }
    public class Daughter : Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter called\n");
        }
    }
    public class Son : Parent
    {

        public Son()
        {
           Console.WriteLine("\tSon Called\n");
        }

        public Son(int num):base(num)
        {
            Console.WriteLine("\tSon+ Called: " + num);
        }
    }
}
