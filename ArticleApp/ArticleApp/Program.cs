using System;

namespace ArticleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article("Interfaces", "Anders");

            Console.WriteLine("please enter a format e.g text, json, xml, pdf");

            //Need a Factory that should return

            string format = Console.ReadLine();

            while (format != "")
            { 
                //string aritcleInTextFormat = article.Write(format);
                Factory factory = new Factory();

                try
                {
                    IWriter writer = factory.GetWriter(format);
                    Console.WriteLine(article.Write(writer));
                }
                catch (NotSupportedException e)
                {
                    Console.WriteLine(e.Message);
                }

               // Console.WriteLine(aritcleInTextFormat);
                format = Console.ReadLine();
            }
            
        }
    }
}
