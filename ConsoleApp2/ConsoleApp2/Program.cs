using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Write a Desired Num to Get a Table");
                int i;
                int k = 1;
                String j = Console.ReadLine();
                Console.WriteLine("You enterd {0}", j);
                i = int.Parse(j);
                while (k < 11)
                {
                    int M = i * k;
                    Console.WriteLine(M);
                    k++;
                }



                Console.WriteLine("Do You want another table: [Y] or [N]");
                String ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                {
                    continue;

                }
                else if (ans == "N")
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
