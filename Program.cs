using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine("please enter a number");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) 
                {
                    sum = sum + i;
                }
            
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is perfect number");
            }
            else
            {

                Console.Write(num + " is not a perfect number");
            }
            Console.ReadKey();
        }
    }
}
