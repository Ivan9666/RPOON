using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    class ShippingService
    {
        private double priceForMass;

        public ShippingService(double priceforMass)
        {
            this.priceForMass = priceforMass;
        }

        public double PriceForMass { get { return this.priceForMass; } }

        internal double shipping(double weight)
        {
            return this.priceForMass * weight;
        }

    }
}
