using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_2zad
{
    class Program
    {
        static void Main()
        {
            MatrixGenerator mg = MatrixGenerator.GetInstance();
            double[][] matrix = mg.GenerateMatrix(5, 6);
            foreach (double[] row in matrix)
            {
                foreach (double elem in row)
                {
                    System.Console.Write(elem + " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
