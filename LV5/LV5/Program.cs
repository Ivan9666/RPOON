using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product inception = new Product("Titanic", 10, 3);
            Box movieBox = new Box("MovieBox");

            movieBox.Add(inception);
            Console.WriteLine(movieBox.Description());
            Console.WriteLine(movieBox.Weight);

            ShippingService service = new ShippingService(0.3);    
            Console.WriteLine(service.shipping(movieBox.Weight));

        }
    }
}
