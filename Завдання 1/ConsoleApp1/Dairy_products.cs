using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dairy_products:Product
    {
        private DateTime expiration_date;
        public DateTime Expiration_Date
        {
            get { return expiration_date; }
            set
            {
                expiration_date = value;
            }
        }
        public Dairy_products(string name, double price, DateTime expiration_date):base(name,price)
        {
            this.expiration_date = expiration_date;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var other = (Dairy_products)obj;
            return (this.name == other.name) && (this.expiration_date == other.expiration_date);
        }
        public override string ToString()
        {
            return "Назва: " + this.name + ". Цiна: " + this.price + ". Вжити до "+this.expiration_date+".";
        }
        public void change_price(double percentage)
        {
            double percent = price / 100;
            if (expiration_date==DateTime.Today)
            {
                price = price + (percent - 50) * percentage;
            }
            else if(expiration_date<DateTime.Today){
                price = 0;
            }
            else
            {
                base.change_price(percentage);
            }
        }
    }
}
