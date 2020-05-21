using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomgenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomgenerator;
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }

        public int rolledNumber { get; set; }
    }
}
