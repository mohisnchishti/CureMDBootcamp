using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1;
          
            Console.WriteLine("enter the string");
           string1= Console.ReadLine();
            for (int i=string1.Length-1; i >= 0; i--)
            {
                Console.Write(string1[i]);
            }
            Console.ReadKey();
        }
    }
}
