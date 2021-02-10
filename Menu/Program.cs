using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Menu.Models;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Pizzas List -----------");

            ShowPizzaList(Repository.GetPizzas());

            Console.WriteLine("--------- CRUD Menu -------------");

            PrintCrudMenue(Repository.GetCrudChoices());
           
            Console.WriteLine("=================================\n\n");

            string userInput = Console.ReadLine();

            while (userInput != "q")
            {
                
                DoCRUD(userInput);
                ShowPizzaList(Repository.GetPizzas());

                userInput = Console.ReadLine();
            }

        }

        //Shows a list of existing pizzas
        static void ShowPizzaList(Dictionary<int,Pizza> pizzas)
        {

            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"[ {pizza.Key} ] [ {pizza.Value.Name} ]");
            }

            Console.WriteLine("Please Enter 1 to Add, 2 to Delete, 3 to Update a pizza");
            Console.WriteLine("OR Enter q to quit");
        }

        
        //prints a Create, Update, Delete menu
        static void PrintCrudMenue(List<string> menu)
        {
            int i = 1;
            foreach (var m in menu)
            {
                Console.WriteLine($"[ {i++} ] [ {m} ]");
            }
        }


        static void DoCRUD(string input)
        {
            switch (input)
            {
                case "1":
                    CreatePizza();
                    break;
                case "2":
                    DeletePizza();
                    break;
                default:
                    NotFound();
                    break;
            }
        }


        static void CreatePizza()
        {
            Console.WriteLine("Enter Pizza Name");
            string pizzaName = Console.ReadLine();
            Pizza pizza = new Pizza() { Name = pizzaName };
            Repository.CreatePizza(pizza);
        }

        static void DeletePizza()
        {
            Console.WriteLine("Enter Pizza number");
            string pizzaNumber = Console.ReadLine();
            Repository.DeletePizza(Int32.Parse(pizzaNumber));
        }

        static void NotFound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Update method is not implemented yet");
            Console.ResetColor();
        }
    }
}
