using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class Program
    {
        static void Main()
        {
            {
                Dataset ds = new Dataset(System.AppDomain.CurrentDomain.BaseDirectory + "Dataset.csv");
                System.Console.WriteLine(ds);
            }
        }
    }
}
