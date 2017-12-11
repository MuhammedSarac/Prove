using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorsdagsWork
{
    class Product
    {
        public int productID;
        public string navn { get; set; }
        public string describtion { get; set; }
        public double weigth { get; set; }
        public int pris;
        // Forskel pa internal class og class er internal er encapsulation

        public void Vare()
        {
            Console.WriteLine(("Dette er et vare"));
        }
    }
}
