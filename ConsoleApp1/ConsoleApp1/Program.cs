using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        int B = 20;
        static void Main(string[] args)
        {
            int A = 10;
            int C=7;
            Console.WriteLine("Hello World");
            Console.WriteLine(A+""+C);
            int B = A + C;
            Console.WriteLine(B);
            Program Pro = new Program();
            Console.ReadLine();
        }
    }
}
