using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader straamReader = null;
            try
            {
                 straamReader = new StreamReader(@"C:\files\text.txt");
                string txt = straamReader.ReadToEnd();
                Console.WriteLine("The text in file is={0}", txt);
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file if exist{0}",ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (straamReader != null)
                {
                    straamReader.Close();
                }
                Console.WriteLine("Finally block");

            }
            Console.ReadLine();     
            
        }
    }
}
