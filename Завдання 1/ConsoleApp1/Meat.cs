using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meat : Product
    {
        enum Categories { Вищий_сорт, Перший_сорт, Другий_сорт };
        enum Sorts { баранина, телятина, свинина, курятина };
        private int category;
        public int Category { 
            get { return category; }
            set
            {
                if ( value>-1 && value < 3)
                {
                    category = value;
                }
            }
        }
        private int sort;
        public int Sort
        {
            get { return sort; }
            set
            {
                if (value > -1 && value <4)
                {
                    sort = value;
                }
            }
        }
        public Meat(string name,int category, int sort, double price, double weight):base(name,price,weight)
        {
            this.category = category;
            this.sort = sort;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var other = (Meat)obj;
            return (this.category == other.category) && (this.sort == other.sort);
        }
        public override string ToString()
        {
            return "Категорiя: " + Enum.GetName(typeof(Categories), this.category) + ". Вид: " + Enum.GetName(typeof(Sorts), this.sort) + ". Цiна: " + this.price + ".";
        }
        public void change_price(double percentage)
        {
            double percent = price / 100;
            switch (category)
            {
                case 0:
                    price = price + (percent + 25) * percentage;
                    break;
                case 1:
                    price = price + (percent + 15) * percentage;
                    break;
                case 2:
                    price = price + (percent + 10) * percentage;
                    break;
                default:
                    base.change_price(percentage);
                    break;
            }
        }
    }
}
