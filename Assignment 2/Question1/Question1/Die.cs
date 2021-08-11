using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1
{
    public class Die
    {
        int topSide;
        int numSides;
        public Die() : this(6)
        {
        }

        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }

        public int TopSide
        {
            get { return topSide; }
        }
        public int NumSides
        {
            get { return numSides; }
        }
        public void Roll()
        {
            topSide = RandomNumberGenerator.Next(numSides) + 1;
        }

        
    }
}
