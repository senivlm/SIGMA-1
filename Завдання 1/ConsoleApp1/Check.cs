using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Check
    {,,,фівпаліфпв
        public static void seeProductInfo(Product pr)
        {
            Console.WriteLine($"Назва: {pr.Name}. Цiна: {pr.Price}. Вага: {pr.Weight}.");
        }
        public static void seeBuyInfo(Buy b)
        {
            Console.WriteLine($"Назва: {b.Name}. Кiлькiсть: {b.Quantity}. Цiна: {b.Price}. Вага: {b.Weight}.");
        }
    }
}
