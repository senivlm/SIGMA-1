using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Buy:Product
    {
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if(value > 0)
                {
                    quantity = value;
                }
            }
        }
        public Buy(string name, double price, int quantity):base(name,price)
        {
            this.quantity = quantity;
        }
        public Buy(string name, double price, double weight, int quantity) : base(name,price,weight)
        {
            this.quantity = quantity;
        }
    }
}