using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("F) Fahrenheit to Celcius\n" +
                    "C) Celsius to Fahrenheit\n" +
                    "E) Exit\n");
                string selection = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (selection)
                {
                    case "F":
                    case "FAHRENHEIT":
                        Console.WriteLine("Temperature in Fahrenheit, please: ");
                        decimal Fahrenheit = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Your Fahrenheit temperature is equal to " + ((Fahrenheit - 32) / (9.0m / 5.0m)) + "\x00B0 in celsius.\n\n" +
                            "Would you like to make another conversion?\n" +
                            "Y) Yes\n" +
                            "N) No\n");
                        string yesOrNo = Console.ReadLine().ToUpper();
                        switch (yesOrNo)
                        {
                            case "Y":
                            case "YES":
                                break;
                            case "N":
                            case "NO":
                                repeat = false;
                                break;
                            default:
                                Console.WriteLine("That was not a valid option\nPlease try again.");
                                break;
                        }
                        break;
                    case "C":
                    case "CELSIUS":
                        Console.WriteLine("Temperature in celsius, please: ");
                        decimal celsius = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Your celsius temperature is equal to " + ((celsius * (9.0m / 5.0m)) + 32) + "\x00B0 in Fahrenheit.\n\n" +
                            "Would you like to make another conversion?\n" +
                            "Y) Yes\n" +
                            "N) No\n");
                        string yesOrNo2 = Console.ReadLine().ToUpper();
                        switch (yesOrNo2)
                        {
                            case "Y":
                            case "YES":
                                break;
                            case "N":
                            case "NO":
                                repeat = false;
                                break;
                            default:
                                Console.WriteLine("That was not a valid option\nPlease try again.");
                                break;
                        }
                        break;
                    case "E":
                    case "EXIT":
                        Console.WriteLine("Thank you for using my temperature converter!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("That was not a valid option\nPlease try again.");
                        break;
                }

            } while (repeat);
        }
    }
}
