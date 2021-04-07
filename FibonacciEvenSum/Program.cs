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
            //Prompt
            #region Notes
            //Fibonacci Sequence
            //1 + 1 = 2;
            //2 + 1 = 3;
            //3 + 2 = 5;
            //5 + 3 = 8;
            //8 + 5 = 13;
            //13 + 8 = 21;
            //21 + 13 = 34;
            //34 + 21 = 55;
            //55 + 34 = 89;

            //Sum of even-numbered fibonacci sequence values under 4,000,000

            #endregion


            long x = 0;
            long y = 1;
            long z = 2;//set up 3 variables

            List<long> fibonacciNums = new List<long>();//Created a list to store fibonacci sequence numbers

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ALL NUMS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            do
            {
                z = x + y;
                fibonacciNums.Add(z);
                y = z + x;
                fibonacciNums.Add(y);
                x = y + z;
                fibonacciNums.Add(x);
            } while (x < 3000000 && y < 3000000 && z < 3000000); //trading the values of 3 variables through simple addition (fibonacci sequence formula) and adding each # to the list

            List<long> evenFibonacciNums = new List<long>();//created a list for the even numbers in the sequence

            foreach (long a in fibonacciNums)//displaying the items in the fibonacci sequence collection for reference
            {
                Console.WriteLine(a);
                if (a % 2 == 0)
                {
                    evenFibonacciNums.Add(a);//if the # in the fibonacci sequence is divisible by 2 (even), it will be added to this list
                }
            }


            //Console Display Considerations and Results
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("EVEN NUMS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            foreach (long a in evenFibonacciNums)//displaying each item in the fibonacci sequence to the screen for reference
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SUM OF EVEN NUMS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"= " + evenFibonacciNums.Sum());
            Console.WriteLine();            
        }
    }
}
