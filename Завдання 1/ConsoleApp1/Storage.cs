using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Storage
    {
        private Product[] products;
        public Storage()
        {
            products = new Product[10];
        }
        public Product this[int index]
        {
            get
            {
                return products[index];
            }
            set
            {
                products[index] = value;
            }
        }
        public void insert_basic_data(int index)
        {
            Console.WriteLine("Введiть назву:");
            products[index].Name = Console.ReadLine();
            Console.WriteLine("Введiть вагу:");
            products[index].Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть цiну:");
            products[index].Price = Convert.ToDouble(Console.ReadLine());
        }
        public void print_info()
        {
            for(int i = 0; i < products.Length; i++)
            {
                Check.seeProductInfo(products[i]);
            }
        }
        public void change_all_price(double percentage)
        {
            for(int i=0; i < products.Length; i++)
            {
                products[i].change_price(percentage);
            }
        }
        public void show_meat()
        {
            for(int i =0; i < products.Length; i++)
            {
                if(products[i] is Meat)
                {
                    Console.WriteLine(products[i].ToString());
                }
            }
        }
    }
}