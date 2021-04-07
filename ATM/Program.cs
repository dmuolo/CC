using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //per brief, the correct account # is hard-coded for the purposes of this exercise
            int correctAccount = 129401179;
            bool repeat = true;

            //checking for login attempts (cannot exceed 3)
            for (int loginAttempts = 1; loginAttempts <= 3 && repeat; loginAttempts++)
            {
                Console.Clear();
                Console.WriteLine("Welcome to ATM!\nPlease enter your account number: ");
                string accountNumberEntry = Console.ReadLine();
                //Parsing user input to an integer to check for authentication purposes
                int accountNumber = Int32.Parse(accountNumberEntry);

                #region Login

                if (accountNumber == correctAccount)//checking for account #
                {
                    //checking for pin login attempts (cannot exceed 3)
                    for (int pinLoginAttempts = 1; pinLoginAttempts <= 3 && repeat; pinLoginAttempts++)
                    {
                        Console.WriteLine("Please provide your pin number: ");
                        string pinNumberEntry = Console.ReadLine();
                        int pinNumber = Int32.Parse(pinNumberEntry);//User enters their pin #, which is captured to this variable

                        int correctPinNumber = 1075;

                        if (pinNumber == correctPinNumber)//checking for pin #
                        {

                            #region Menu

                            do//MENU code
                            {
                                Console.Clear();
                                Console.WriteLine("Please select from the following options:\n" +
                                    "D) Deposit\n" +
                                    "W) Withdrawal\n" +
                                    "E) Exit\n");

                                string selection = Console.ReadLine().ToUpper();

                                Console.Clear();

                                switch (selection)
                                {
                                    case "D":
                                    case "DEPOSIT":
                                        Console.Write("How much would you like to deposit? $");
                                        decimal depositDecimal = Decimal.Parse(Console.ReadLine());
                                        string deposit = Convert.ToString(depositDecimal);

                                        Console.WriteLine("\n$" + deposit + " has been deposited in Account 129401179.\n\n" +
                                            "Would you like to make another transaction?\n" +
                                            "Y) Yes\n" +
                                            "N) No\n");
                                        string yesOrNo = Console.ReadLine().ToUpper();

                                        switch (yesOrNo)//Another transaction?
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

                                    case "W":
                                    case "WITHDRAWAL":
                                        Console.Write("How much would you like to withdraw? $");
                                        decimal withdrawalDecimal = Decimal.Parse(Console.ReadLine());
                                        string withdrawal = Convert.ToString(withdrawalDecimal);

                                        Console.WriteLine("\n$" + withdrawal + " has been withdrawn from Account 129401179.\n\n" +
                                            "Would you like to make another transaction?\n" +
                                            "Y) Yes\n" +
                                            "N) No\n");
                                        string yesOrNo2 = Console.ReadLine().ToUpper();
                                        switch (yesOrNo2)//Another transaction?
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
                                        repeat = false;
                                        break;
                                    default:
                                        Console.WriteLine("That was not a valid option\nPlease try again.");
                                        break;

                                }

                            } while (repeat);
                        }

                        #endregion

                        else
                        {
                            Console.WriteLine("Please try again.\n");
                        }

                    }
                }

                else
                {
                    Console.WriteLine("Please try again.\n");
                }

                #endregion
            }

            Console.Clear();
            Console.WriteLine("Thank you for your business!");

        }
    }
}
