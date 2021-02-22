
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FunctionsAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A first attempt at parameterising code");

            Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

            carsDict.Add("CJ 32 802", new Car("BMW", "CJ 32 802", 1000));
            carsDict.Add("CJ 32 803", new Car("Audi", "CJ 32 803", 2000));
            carsDict.Add("CJ 32 804", new Car("Porsche", "CJ 32 804", 3000));
            
            Console.WriteLine("It is easy and quick to find a car object in a dictionary, because dictionary uses keys");
            string licensPlate = "CJ 32 802";

            if (carsDict.ContainsKey(licensPlate))
            {
                Console.WriteLine(carsDict[licensPlate].Model);
            }


            Console.WriteLine("if due to some reason our cars objects are saved in a list");

            List<Car> carsList = new List<Car>();
            carsList.Add(new Car("BMW", "CJ 32 802", 1000));
            carsList.Add(new Car("Audi", "CJ 32 803", 2000));

            Console.WriteLine("it is slower and needs more logic to find a car object in a list. You have to loop over entire list");

            int price = 2000;

            Car theCar = null;
            ////foreach (Car aCar in carsList)
            ////{
            ////    if (aCar.Price == price)
            ////    {
            ////        theCar = aCar;
            ////    }
            ////}

            //Console.WriteLine(theCar);

            foreach (Car aCar in carsList)
            {
                if (PriceMatch(aCar, price))
                {
                    theCar = aCar;
                }
            }

            Console.WriteLine(theCar);

            //Explicitly declaring a Predicate: the the long version
            Predicate<Car> carMatchFunc = (Car c) => { return c.Price == price; };
            //Explicitly declaring a Predicate: the short version
            //Predicate<Car> carMatchFunc =  c => c.Price == price;
            //Car matchCar = carsList.Find(carMatchFunc);

            //Implicit usage of a Predicate i.e Lambda
            Car matchCar = carsList.Find(c => c.Price == price);

            Console.WriteLine($"found by predicate : {matchCar}");

            Car matchCarByLicense = carsList.Find(c => c.LicensePlate == licensPlate);

            Console.WriteLine(matchCarByLicense);

        }

        private static bool PriceMatch(Car aCar, int price)
        {
            return aCar.Price == price;
        }
        
    }

   

    public class Car
    {
        public string _licensePlate;

        public Car(string model, string licensePlate, int price)
        {
            Model = model;
            _licensePlate = licensePlate;
            Price = price;
        }


        public string LicensePlate
        {
            get { return _licensePlate; }
        }

        public string Model { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"{LicensePlate} {Model} {Price}";
        }
    }
}



