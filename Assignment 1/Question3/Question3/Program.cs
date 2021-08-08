using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            string[] words = new string[s.Length];
            int k = 0;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                
                if(s[i]==' ')
                {
                    k++;
                    temp = "";
                }
                else
                {
                    temp = temp + s[i];
                }
                words[k] = temp;
            }
            string rword = "";
            Console.WriteLine();
            Console.WriteLine("Reversed words:");
            for (int f = 0; f <= k; f++)
            {
                char[] letters = words[f].ToCharArray();
                for (int i = 0, j = words[f].Length - 1; i < j; i++, j--)
                {
                    letters[i] = words[f][j];
                    letters[j] = words[f][i];
                }
                rword = new string(letters);
                Console.Write(rword + "\t ");
            }
            Console.WriteLine();
        }
    }
}
