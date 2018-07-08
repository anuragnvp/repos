using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int e = 10;
            //int f = 20;
            Example obj = new Example();
            obj.Print(ref obj.e,ref obj.f, out int c,out int d);
            Console.WriteLine("value of c is{0} and value of d is{1}", c, d);
            Console.ReadLine();
        }
        //object[] name = new object[5];
        //public override string ToString()
        //{
        //    return "anurag";
        //}
    }
    class Example
    {
       public int e = 10;
        public int f = 20;
        public void Print(ref int a, ref int b,out int c,out int d)
        {
             c = a + b;
             d = a * b;
        }
    }
}
