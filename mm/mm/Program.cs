using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int num;
            int c = 0;
            Console.WriteLine("please enter the number");
            num=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("The fabonacci series is");
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }

            Console.ReadKey();
        }
    }
}
