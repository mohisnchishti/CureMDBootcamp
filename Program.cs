using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("please enter the size of n");
            n = int.Parse(Console.ReadLine());
            int x = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = n-1; j >i; j--)
                {
                    Console.Write(" ");
                   
                }

                for(int k = 1; k <= 2*i+1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");


            }
            Console.ReadKey();
        }
       
    }
}

