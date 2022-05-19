using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Гречка",10.5,15.5);
            Check.seeProductInfo(product1);
            Buy buy1 = new Buy("Хліб",23.5,1);
            Check.seeBuyInfo(buy1);
            DateTime dt1 = new DateTime(2022, 10, 15);
            Dairy_products milk = new Dairy_products("Молоко",16,dt1);
            Meat meat = new Meat("Фарш",0,0,20,1);
            Storage storage = new Storage();
            storage[0] = product1;
            storage[1] = milk;
            storage[2] = meat;
            storage.show_meat();
        }
    }
}
