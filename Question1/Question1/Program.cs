using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length of array: ");
            int l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements: ");
            int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("Enter element " + (i+1));
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                temp = arr[0];
                arr[0] = arr[j + 1];
                arr[j + 1] = temp;
            }
            Console.WriteLine("Output array:");
            for (int i = 0; i < l; i++)
            {
                Console.Write( arr[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
