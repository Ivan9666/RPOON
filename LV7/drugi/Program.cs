using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 2, 3, 23, 6, 66, 4, 45, 576, 55, 2, 4, 365, 33, 73, 103, 33, 86, 55, 25, 56, 366, 99, 399, 5, 27, 11, 2, 222, 40, 255, 0, 425 };
            NumberSequence sequence = new NumberSequence(array);

            sequence.SetSortStrategy(new BubbleSort());
            sequence.SetSearchStrategy(new LinearSearch());
            int numberToSerachFor = 7;
            Console.WriteLine(sequence.Search(numberToSerachFor));
            sequence.Sort();
            Console.WriteLine(sequence.Search(numberToSerachFor));
        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("-------------------");
        }
    }
}
