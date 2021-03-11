using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is defined by the recurrence relation:

            //Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144. 
            //F12 is the first term to contain three digits.

            //What is the index of the first term in the Fibonacci sequence to contain 10 digits?

            long xx = 0;
            long y = 1;
            long z = 2;//set up 3 variables for fibonacci sequence

            List<long> fibonacciNums = new List<long>();

            do
            {
                z = xx + y;
                fibonacciNums.Add(z);
                y = z + xx;
                fibonacciNums.Add(y);
                xx = y + z;
                fibonacciNums.Add(xx);//storing fibonacci sequence #s in list
            } while (xx < 1000000000 && y < 1000000000 && z < 1000000000); //trading the val

            List<string> lengths = new List<string>();//declared list of strings

            foreach (long a in fibonacciNums)//displaying the items in the fibonacci sequence collection for reference
            {
                lengths.Add(a.ToString());//added each long to the list of strings for string method functionality purposes
            }

            foreach (string a in lengths)
            {
                if (lengths.All(x => x.Length < 11))//x evaluates to all items in List "lengths"  where the length is less than 11
                    //Just so happens there is only one item in the fibonacci sequence with a length of 10
                {
                    Console.WriteLine("[" + lengths.IndexOf(a) + "] " + " " + a + " " + $" Length: {a.Length}");//displays the index, #, and length of # for each # in the fibonacci sequence up to the solution. //Only issue present is that the 2nd index also shows as "0" since both are equal to 1.
                }
            }
        }//end main
    }//end class
}//end namespace
