using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    
    static class RandomNumberGenerator
    {
        static Random rand;
        public static void Initialize()
        {
            rand = new Random();
        }
        public static int Next(int maxValue)
        {
            return rand.Next(maxValue);
        }
    }
}
