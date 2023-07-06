using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min; 
            int[] arr = new int[10];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            max= arr[0];
            min= arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    arr[i] = min;
                }
                
            }
            Console.WriteLine("minimun number in array is " + min);
            Console.WriteLine("maximum number in array is " + max);
            Console.ReadKey();
        }
    }
}
