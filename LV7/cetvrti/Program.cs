using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_treci
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("log.txt");
            SystemDataProvider dataProvider = new SystemDataProvider();
            dataProvider.Attach(fileLogger);
            dataProvider.Attach(consoleLogger);

            while (true)
            {
                dataProvider.GetCPULoad();
                dataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("-------------------");
        }
    }
}