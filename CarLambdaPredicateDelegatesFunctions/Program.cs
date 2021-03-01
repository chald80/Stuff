using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLambdaPredicateDelegatesFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("xxx", 2000));
            cars.Add(new Car("zzz", 2010));
            cars.Add(new Car("yyy", 2015));
            // Car C1 = new Car("xxx", 2000);
            // Car C2 = new Car("zzz", 2010);
            // Car C3 = new Car("yyy", 2015);

            string _searchCriteria = "zzz";
            Car theCar = null;
            
            foreach (Car aCar in cars)
            {
                if (CarModelSearch(aCar, _searchCriteria ))
                {
                    theCar = aCar;
                }
            }

            Console.WriteLine(theCar);

           Predicate<Car> carMatchFunc = (Car c) => { return c.Model == _searchCriteria; };

           Predicate<Car> carSearch = new Predicate<Car>(CarModelSearch2);



        }
        public static bool CarModelSearch(Car aCar, string _searchCriteria)
        {
            return aCar.Model.Equals(_searchCriteria);
        }
        public static bool CarModelSearch2(Car aCar)
        {
            return aCar.Model.Equals("zzz");
        }


    }


    public class Car
    {
        private string _model;
        private int _year;

        public Car(string model, int year)
        {
            _model = model;
            _year = year;
        }

        public string Model
        {
            get { return _model;}
            set { _model = value; }
        }

        public int Year
        {
            get { return _year;}
            set { _year = value; }
        }
        public override string ToString()
        {
            return $"{Year} {Model}";
        }

    }




}
