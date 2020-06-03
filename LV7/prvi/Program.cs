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
            NumberSequence sequence1 = new NumberSequence(array);
            NumberSequence sequence2 = new NumberSequence(array);
            NumberSequence sequence3 = new NumberSequence(array);
            sequence1.SetSortStrategy(new BubbleSort());
            sequence2.SetSortStrategy(new CombSort());
            sequence3.SetSortStrategy(new SequentialSort());

            Console.WriteLine(sequence1);
            sequence1.Sort();
            Console.WriteLine(sequence1);

            OutputSeparationLine();

            Console.WriteLine(sequence2);
            sequence2.Sort();
            Console.WriteLine(sequence2);

            OutputSeparationLine();

            Console.WriteLine(sequence3);
            sequence3.Sort();
            Console.WriteLine(sequence3);


        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("---------------------");
        }
    }
}
