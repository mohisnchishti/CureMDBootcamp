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
            int number;
          
            Console.WriteLine("enter the number");
            number = Convert.ToInt16(Console.ReadLine());
             
            for (int i = 2; i <= number; i++)
            { 
                if(IsPrime(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }

        static bool IsPrime(int num)
        {
            bool p = true;
            for(int i = 2; i<num; i++)
            {
                if(num%i == 0)
                {
                    p = false;
                }
            }
            return p;
        }
    }
}
