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
            RandomNumberGenerator.Initialize();
            Die die1 = new Die();
            Die die2 = new Die();
            die1.Roll();
            die2.Roll();
            int top1 = die1.TopSide;
            int top2 = die2.TopSide;
            Console.WriteLine(top1 + " " + top2 + " " + (top1 + top2));
            Console.WriteLine();
        }
    }
}
