using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following iterative sequence is defined for the set of positive integers:

            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            //It can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms. Although it has not been proven yet, it is thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces the longest chain ?

            //NOTE : Once the chain starts the terms are allowed to go above one thousand.

            int count = 0;
            bool exit = false;

            List<long> longs = new List<long>();
            Dictionary<long, int> results = new Dictionary<long, int>();

            for (int i = 3; i < 1000; i++)
            {
                longs.Add(i);
            }

            foreach (long b in longs)
            {
                long a = b;
                count = 0;
                //Console.WriteLine();
                //Console.WriteLine(b);
                exit = false;
                while (!exit)
                {
                    if (a % 2 == 0)
                    {
                        count++;
                        a = a / 2;
                        //Console.WriteLine(a);
                    }
                    else if (a % 2 != 0)
                    {
                        if (a <= 1)
                        {
                            count++;
                            Console.WriteLine($"Sequence: " + $"{count}");
                            exit = true;
                        }
                        else
                        {
                            count++;
                            a = (3 * a) + 1;
                            //Console.WriteLine(a);
                        }

                    }
                }//end while
                if (count > 150)
                {
                    results.Add(b, count);
                }
                else
                {

                }
            }//end foreach

            Console.WriteLine();

            Console.WriteLine("Numbers having a sequence length greater than 150:");
            Console.WriteLine();

            foreach (KeyValuePair<long, int> c in results)
            {
                Console.WriteLine("Number = {0}", c.Key);
                Console.WriteLine("Sequence Length = {0}", c.Value);
                Console.WriteLine();
            }

        }
    }
}
