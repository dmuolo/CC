using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Sequence
            //1 + 1 = 2;
            //2 + 1 = 3;
            //3 + 2 = 5;
            //5 + 3 = 8;x  y  z
            //8 + 5 = 13;z  x  (z+x) = y?
            //13 + 8 = 21;y + z (y + z = x)?
            //21 + 13 = 34;
            //34 + 21 = 55;
            //55 + 34 = 39;

            //Sum of even-numbered fibonacci sequence values under 4,000,000

            //if statement to test if divisible by 2?
            long x = 0;
            long y = 1;
            long z = 2;

            List<long> fibonacciNums = new List<long>();

            do
            {
                z = x + y;
                fibonacciNums.Add(z);
                y = z + x;
                fibonacciNums.Add(y);
                x = y + z;
                fibonacciNums.Add(x);
            } while (x < 3000000 && y < 3000000 && z < 3000000);

            List<long> evenFibonacciNums = new List<long>();

            foreach (long a in fibonacciNums)
            {
                Console.WriteLine(a);
                if (a % 2 == 0)
                {
                    evenFibonacciNums.Add(a);
                }
            }

            foreach (long a in evenFibonacciNums)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine($"= " + evenFibonacciNums.Sum());

            //long fibonacci = 1;

            //long fibonacci2 = 1;

            //long hello = 0;
            //do
            //{
            //    if (hello > 1)
            //    {
            //        fibonacci2 = hello;
            //    }
            //    hello = fibonacci2;
            //    fibonacci2 = fibonacci + fibonacci2;
            //    Console.WriteLine(fibonacci2);
            //    fibonacci = fibonacci2;
            //} while (fibonacci < 4000000 || fibonacci2 < 4000000);

            
        }
    }
}
