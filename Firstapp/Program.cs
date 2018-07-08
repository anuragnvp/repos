using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            String appname = "Firstapp";
            String appversion ="1.0.0";
            String appdeveloper = "Anurag";
            Console.WriteLine("{0}: Version {1} by {2}",appname,appversion,appdeveloper);
            Console.ResetColor();
            Console.WriteLine("Hello what is your name?");
            String inputName = Console.ReadLine();
            Console.WriteLine("Hi {0}, let's play a game",inputName);
            while(true) { 
            Random random = new Random();
            int CorrectNumber = random.Next(1,10);
            int guess = 0;
            Console.WriteLine("Guess a number betweebn 1 and 10");
                while (guess != CorrectNumber)
                {
                    String input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an actual number.");
                        Console.ResetColor();
                        continue;

                    }
                    guess = Int32.Parse(input);
                    if (guess != CorrectNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("wrong number, please try again");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("YOU ARE CORRECT!!!");
                        Console.ResetColor();
                    }
                }
                    Console.WriteLine("Play Again? [Y or N]");
                    String answer = Console.ReadLine().ToUpper();
                    if (answer=="Y") {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                
            }

        }
    }
}
