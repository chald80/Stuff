using System;
using System.Runtime.InteropServices;

namespace EqualsGetHashCodeToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 10;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));
            //Customer C1 = new Customer();
            //C1.ID = 100;
            //C1.Name = "Allan";
            //Customer C2 = C1;
            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C1.Equals(C2));
            
            Customer C1 = new Customer();
            C1.ID = 100;
            C1.Name = "Allan";

            Customer C2 = new Customer();
            C2.ID = 100;
            C2.Name = "Allan";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }

    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return (ID == ((Customer) obj).ID && Name == ((Customer) obj).Name);
        }

    }
}
