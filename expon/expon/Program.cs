using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expon
{
    class Program
    {
        static void Main(string[] args)
        {
            Exponent ex = new Exponent();
            Console.WriteLine(ex.exp1(5));
            Console.ReadLine();
        }
    }
    class Exponent
    {
       Double a,b,num;
        public double exp1(double d)
        {
            b = (d * d) - d;
            
            do
            {
                d--;
               return num= b * (d - 1);
            } while (d != 0);
            // Console.WriteLine(b);
            
        }
        
    }
}
