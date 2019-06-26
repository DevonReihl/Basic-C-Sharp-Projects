using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAndConstructors
{
    class Customers
    {

        public Customers (string name) : this (name, "nothing", 0)// Chained constructors incase they do not purchase today.
        {
        }
        public Customers (string name, string currentPurchase, int currentPurchasePrice)
        {
            Name = name;
            Purchase = currentPurchase;
            PurchasePrice = currentPurchasePrice;

        }

        public string Name { get; set; }
        public string Purchase { get; set; }
        public int PurchasePrice { get; set; }
    }
}
