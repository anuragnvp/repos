using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Car newcar = new Car();

            newcar.Make = Console.ReadLine();
            Console.WriteLine(newcar.Make);
            Console.ReadLine();
        }
    }
    class Car
    {

        public static void mycar()
        { }
        public String Make { get; set; }
        public String Model { get; set; }
        public String Year { get; set; }
        public String Color { get; set; }
    }
}

    
