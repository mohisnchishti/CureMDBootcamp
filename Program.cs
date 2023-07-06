using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1="";
            string string2;
            Console.WriteLine("enter string");
            Console.ReadLine();
            char[] arr = string1.ToCharArray(); 
            Array.Reverse(arr);
            string2 = new string(arr);
            if (string1 == string2)
            {
                Console.WriteLine("string is palindrome");

            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }

            Console.ReadKey();

        }
    }
}
