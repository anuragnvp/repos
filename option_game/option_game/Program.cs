using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace option_game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose an option to play a game:");
            Console.WriteLine("1) Print Number game");
            Console.WriteLine("2) Number guessing Game");
            Console.WriteLine("3) Name game");
            Console.WriteLine("4) exit");
            int numguess = int.Parse(Console.ReadLine());
            if (numguess == 1)
                Print_number();
            else if (numguess == 2)
                number_guessing();
            else if (numguess == 3)
                Name_Game();
            else if (numguess == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong Input! you Lost");
                
            }
            Console.ReadLine();
        }
        private static void Print_number()
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while(count<num)
            {
                count++;
                Console.Write(count);
                Console.Write("-");
            }
        }
        private static void number_guessing()
        {
            
            bool incorrect = true;
            int total_guess=1;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int result = int.Parse(Console.ReadLine());
                Random num = new Random();
                int randomnum = num.Next(1, 11);
                if (result == randomnum)
                {
                    Console.WriteLine("Correct! You took total {0} guesses",total_guess);
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong try again!");
                    total_guess++;
                }
            } while (incorrect);
        }
        private static void Name_Game()
        {
            Console.WriteLine("What is your first name:");
            String FirstName = Console.ReadLine();
            Console.WriteLine("What is Your Last name:");
            String LastName = Console.ReadLine();
            Console.WriteLine("Enter Your City:");
            String City = Console.ReadLine();/*
            char[] FirstNameArray = FirstName.ToCharArray();
            char[] LastNameArray = LastName.ToCharArray();
            char[] CityArray = City.ToCharArray();
            Array.Reverse(FirstNameArray);
            Array.Reverse(LastNameArray);
            Array.Reverse(CityArray);
            String result = "";
            foreach(char item in FirstNameArray)
            {
                result += item;
            }
            foreach (char item in LastNameArray) 
            { result += item; }
            foreach (char item in CityArray)
            { result += item; }
           

            Console.WriteLine(result);
             ReverseString(FirstName);
            ReverseString(LastName);
            ReverseString(City);*/
            Display(ReverseString(FirstName), ReverseString(LastName), ReverseString(City));


        }
        public static String ReverseString(String message)
        {
            Char[] MessageArray = message.ToCharArray();
            Array.Reverse(MessageArray);
            return String.Concat(MessageArray);
            
        }
        public static void Display(String FirstName,String LastName,String City)
        {
            Console.Write(String.Format("{0} {1} {2}",FirstName,LastName,City));
            Console.ReadLine();
        }
        public static void PlayAgain()
        {
            Console.WriteLine("Do you Want to Play again [Y] or [N]");
            String opt = Console.ReadLine().ToUpper();
            if(opt=="Y")
            { }
            else if(opt=="N")
            { }
            else
            { Console.WriteLine("Wrong input You Lost!")}
        }
    }
}
