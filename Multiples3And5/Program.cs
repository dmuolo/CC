using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> threes = new List<int>();
            string[] numbers = new string[1000];
            int three = 0;
            foreach (string t in numbers)
            {
                if (three < 997)
                {
                    three += 3;
                    threes.Add(three);
                }

            }

            List<int> fives = new List<int>();
            int five = 0;
            foreach (string t in numbers)
            {
                if (five < 995)
                {
                    five += 5;
                    fives.Add(five);
                }

            }

            int threesSum = threes.Sum();
            int fivesSum = fives.Sum();

            Console.WriteLine(threesSum + fivesSum);
        }
    }
}
