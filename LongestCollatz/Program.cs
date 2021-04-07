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

            //Declared list of longs
            List<long> longs = new List<long>();
            //Declared key value pair collection for the results of the the conditions we're about to check; Long for key because each will be unique, int for value because the int represents the # of arithmetic actions in a sequence, and we will end up with duplicates for these values.
            Dictionary<long, int> results = new Dictionary<long, int>();

            //count, condition, update
            //Here, we add numbers under 1000 to a List of longs
            for (int i = 3; i < 1000; i++)
            {
                longs.Add(i);
            }

            //Here, we list out those longs and perform conditional arithmetic operations
            foreach (long b in longs)
            {
                long a = b;
                //setting each long's count to 0 to start
                count = 0;
                exit = false;

                while (!exit)
                {
                    //if A is even
                    if (a % 2 == 0)
                    {
                        //increase count, divide by 2
                        count++;
                        a = a / 2;
                    }
                    //if a is not even
                    else if (a % 2 != 0)
                    {
                        //if # has reached the end of sequence, exit loop for that key in key value pair (value of the actual # being sequenced)
                        if (a <= 1)
                        {
                            count++;
                            Console.WriteLine($"Sequence: " + $"{count}");
                            exit = true;
                        }

                        //If # is odd and is not equal to or less than 1, increase count in sequence tally and perform simple operation
                        else
                        {
                            count++;
                            a = (3 * a) + 1;
                        }
                    }
                }//end while

                //if the results are large relative to this problem's results distribution, add to a list for reference purposes
                if (count > 150)
                {
                    results.Add(b, count);
                }
            }//end foreach

            //Console Application UI Considerations
            Console.WriteLine();
            Console.WriteLine("Numbers having a sequence length greater than 150:");
            Console.WriteLine();

            //Display results
            foreach (KeyValuePair<long, int> c in results)
            {
                Console.WriteLine("Number = {0}", c.Key);
                Console.WriteLine("Sequence Length = {0}", c.Value);
                Console.WriteLine();
            }

        }
    }
}
