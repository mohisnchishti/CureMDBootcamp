using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            int[] arr = new int[10];
            Console.WriteLine("enter the length of array");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbers of array");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <=len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;

                    }

                }
            }
            Console.WriteLine(" the numbers of array");
            for (int i=0; i<len; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.ReadKey();
        }
    }
}
