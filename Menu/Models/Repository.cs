using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Models
{
    class Repository
    {
        private static List<string> CrudMenu = new List<string>()
        {
            "Add Pizza" ,
            "Delete Pizza",
            "Update Pizza"
        };

        private static Dictionary<int, Pizza> Pizzas = new Dictionary<int, Pizza>()
        {
            {
                1, new Pizza() {Id = 23, Name = "SaladPizza"} 

            },
            {
                2, new Pizza() {Id = 24, Name = "PepPizza"}

            },
            {
                3, new Pizza() {Id = 25, Name = "VeggiePizza"}

            },
        };

        public static Dictionary<int, Pizza> GetPizzas()
        {
            return Pizzas;
        }

        public static List<string> GetCrudChoices()
        {
            return CrudMenu;
        }

        public static void CreatePizza(Pizza pizza)
        {
            Pizzas.Add(Pizzas.Count + 1, pizza);
           
        }

        public static void DeletePizza(int key)
        {
            Pizzas.Remove(key);
        }
    }
}
