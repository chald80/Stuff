using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

// ReSharper disable UnusedParameter.Local

namespace LINQDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create drinks
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Drink("Cuba Libre", "Rum", 3, "Cola", 20));
            drinks.Add(new Drink("Russia Libre", "Vodka", 3, "Cola", 20));
            drinks.Add(new Drink("The Day After", "None", 0, "Water", 20));
            drinks.Add(new Drink("Red Mule", "Vodka", 3, "Fanta", 20));
            drinks.Add(new Drink("Double Straight", "Whiskey", 6, "None", 0));
            drinks.Add(new Drink("Pearly Temple", "None", 0, "Sprite", 20));
            drinks.Add(new Drink("High Spirit", "Vodka", 6, "Sprite", 20));
            drinks.Add(new Drink("Watered Down", "Whiskey", 3, "Water", 3));
            drinks.Add(new Drink("Caribbean Gold", "Rum", 6, "Fanta", 20));
            drinks.Add(new Drink("Siberian Zone", "Vodka", 6, "None", 0));
            #endregion

            var alldrinks = from d in drinks
                            select d;
            foreach (var d in alldrinks)
            {
                Console.WriteLine($"{d.Name}");
            }


            Console.WriteLine();

            var withoutalcohol = from d in drinks
                                 where d.AlcoholicPartAmount == 0
                                 select d;
            foreach (var d in withoutalcohol)
            {
                Console.WriteLine($"{d.Name}");
            }

            Console.WriteLine();

            var withalcohol = from d in drinks
                              where d.AlcoholicPartAmount > 0
                              select new { d.Name, d.AlcoholicPart, d.AlcoholicPartAmount };
            foreach (var d in withalcohol)
            {
                Console.WriteLine($"{d.Name}  {d.AlcoholicPart}  {d.AlcoholicPartAmount}");
            }

            Console.WriteLine();

            var order = from d in drinks
                        orderby d.Name
                        select new { d.Name };
            foreach (var d in order)
            {
                Console.WriteLine($"{d.Name}");
            }


            Console.WriteLine();

            var total = from d in drinks
                        select d.AlcoholicPartAmount;
            double Total = total.Sum();
            Console.WriteLine($"{Total}");

            Console.WriteLine();


            var avaerage = from d in drinks
                           select d.AlcoholicPartAmount;
            double Avaerage = avaerage.Average();
            Console.WriteLine($"{Avaerage}");

            Console.WriteLine();






            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
