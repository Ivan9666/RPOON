using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2
{
    class Program
    {
        static void Main()
        {
            int NUMBER_OF_DICE = 20;
            DiceRoller roller = new DiceRoller();
            Random randomGenerator = new Random();

            for (int i = 0; i < NUMBER_OF_DICE; i++)
            {
                roller.InsertDie(new Die(6, randomGenerator));
            }
            roller.RollAllDice();
            IList<int> rollResults = roller.GetRollingResults();
            foreach (int rollResult in rollResults)
            {
                System.Console.WriteLine(rollResult);
            }
        }
    }
}
