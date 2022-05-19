using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        protected string name;
        protected double price;
        protected double weight;

        public string Name { get; set; }
        public double Price { 
            get { return price; }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }
        public double Weight { 
            get { return weight;}
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
            }
        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public Product(string name, double price, double weight):this(name,price)
        {
            this.weight = weight;
        }
        public Product()
        {

        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var other = (Product)obj;
            return (this.name==other.name) && (this.price==other.price);
        }
        public override int GetHashCode()
        {
            return (int)price;
        }
        public override string ToString()
        {
            return "Назва: "+this.name+". Цiна: "+this.price+".";
        }
        public void change_price(double percentage)
        {
            price = price + (price / 100) * percentage;
        }
    }
}