using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string s = Console.ReadLine();
            string sub = "";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
                sub = Convert.ToString( s[i]);
                for (int j = i+1; j < s.Length; j++)
                {
                    sub = sub + s[j];
                    Console.WriteLine(sub);
                }
            }
        }
    }
}
