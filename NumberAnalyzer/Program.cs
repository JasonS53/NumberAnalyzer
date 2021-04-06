using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int userChoice;
            int oddEven;

            do
            {
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();

                while (true)
                {

                    Console.WriteLine("Please choose a number between 1 - 100.");
                    userChoice = int.Parse(Console.ReadLine());

                    oddEven = userChoice % 2;

                    if (oddEven == 1 && userChoice <= 100)
                    {
                        Console.WriteLine($"{ name } {userChoice} " + "Odd.");
                    }
                    else if (oddEven == 0 && userChoice >= 2 && userChoice <= 25)
                    {
                        Console.WriteLine($"{ name } " + "your number is Even and less than 25.");
                    }
                    else if (oddEven == 0 && userChoice >= 26 && userChoice <= 60)
                    {
                        Console.WriteLine($"{ name } " + "your number is Even.");
                    }
                    else if (oddEven == 0 && userChoice >= 60 && userChoice <= 100)
                    {
                        Console.WriteLine($"{ name } {userChoice} " + "Even.");
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

                    Console.WriteLine("Do you want to try again yes or no");
                    while (true)
                    {
                        string result = Console.ReadLine();
                        if (result == "yes")
                        {
                            break;
                        }
                        else if (result == "no")
                        {
                            Console.WriteLine("Thank you for participating");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("That was not a yes or no");
                        }
                    }
                }
            } while (true);
            
            
        }
    }
}
