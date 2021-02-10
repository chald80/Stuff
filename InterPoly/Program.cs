using System;

namespace InterPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Philosopher P1 = new Philosopher();
            Dog D1 = new Dog();
            Cow C1 = new Cow();
            P1.Speak();
            P1.Think();
            D1.Speak();
            C1.Speak();
            ISpeak Speaker = new Dog();
            Speaker.Speak();
            Speaker = new Cow();
            Speaker.Speak();
            Speaker = new Philosopher();
            Speaker.Speak();
            ((Philosopher)Speaker).Think();



        }
    }
}
