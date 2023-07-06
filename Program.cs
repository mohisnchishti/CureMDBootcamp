using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] arr = new int[5];
            Console.WriteLine("please enter the numbers of array");
           
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
           
            for (int j = 0; j < 5; j++)
            {
                if (num == arr[j])
                { 
                Console.WriteLine(num +" is present in th array");
                }
            }
            Console.ReadKey();
        }
    }
}
