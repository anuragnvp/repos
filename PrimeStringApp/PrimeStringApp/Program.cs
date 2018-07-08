using System;
namespace PrimeStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            do
            {
                PrimeString primeString = new PrimeString();
                primeString.GetString();
                primeString.CheckPrime();
                primeString.DisplayResult();
                Console.WriteLine("Do You again want's to check press [Y] for Yes and [N] for exit! ");
                UserInput = Console.ReadLine().ToUpper();
                if(UserInput!="Y" && UserInput != "N")
                { Console.WriteLine("You enterd {0} is not acceptable, game over!",UserInput);
                    break;
                }
            }
            while (UserInput == "Y");

        }
    }
    class PrimeString
    {
        string UserString, String1, String2 = null;
        char[] UserStringArray;
        int count, UserString1, UserStringLength;
        public void GetString()
        {
            Console.WriteLine("Please enter a string");
            UserString = Console.ReadLine();
            UserStringLength = UserString.Length;
            UserStringArray = UserString.ToCharArray();
        }
        public void CheckPrime()
        {
            UserString1 = UserStringLength % 2 == 0 ? UserStringLength / 2 : (UserStringLength % 3 == 0 && UserStringLength % 2 != 0 )? UserStringLength / 3 :0 ;
            for (int i = 0; i < UserString1; i++)
            {
                String1 += UserStringArray[i];
                count++;
            }
            for (int i = count; i <= UserString1 + count - 1; i++)
            {
                String2 += UserStringArray[i];
            }
        }
        public void DisplayResult()
        {
           string str= String.IsNullOrEmpty(String1) ?"It's a Prime String": String1 == String2 && String.IsNullOrEmpty(String1) == false ? "It's not a prime String":"It's a prime string";
            Console.WriteLine(str);
        }
    }
}
