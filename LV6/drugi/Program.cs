using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Keyboard", 22.20);
            Product product2 = new Product("USB", 35.25);
            Product product3 = new Product("Mouse", 35.25);

            Box box = new Box();

            box.AddProduct(product1);
            box.AddProduct(product2);
            box.AddProduct(product3);
            box.RemoveProduct(product3);

            IAbstractIterator boxIterator = box.GetIterator();

            while (!boxIterator.IsDone)
            {
                Console.WriteLine(boxIterator.Current);
                boxIterator.Next();
            }
        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("----------------------");
        }
    }
}