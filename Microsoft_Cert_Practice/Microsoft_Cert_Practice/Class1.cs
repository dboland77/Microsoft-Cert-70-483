using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Cert_Practice
{
    class MyClass
    {
        /* Lambda expression explanation */
        // Two types of lamda expression
        // Expression lamda that has an expression as its body
        // (input-parameters) => expression
        // Statement lamda
        // (input-parameters) => {<sequence-of-statements>}
        // => is the lamda declaration operator
        // a lamda expression can be converted to a delegate type. If it does not return a value then it can be converted to one 
        // of the Action delegate types. For example a lamda expression that has two parameters and returns no value can be 
        // converted to an Action<T1,T2> delegate. In the following example, the lamda expression x => x*x, which specifies a 
        // parameter that is named x and returns the value of x squared, is assigned to a variable of a delegate type
        static void main()
        {
            Func<int, int> square = x => x * x; // so Func<int,int> is an Action delegate - takes an int gives an int
            Console.WriteLine(square(5));
            Console.ReadKey();
        }
       
      
    }
}
