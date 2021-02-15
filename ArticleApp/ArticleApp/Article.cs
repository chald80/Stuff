using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp
{
    class Article
    {
        private string article = "";
        public Article(string title, string author)
        {
            Title = title;
            Author = author;
            Date = DateTime.Now.ToString("dd'-'MM'-'yyyy  HH':'mm");
        }

        public string Title { get; }

        public string Author { get; }

        public string Date { get; }

        public string Write(IWriter writer)
        {
            return writer.Write(this);
        }

        /*
        public string Write(string format)
        {
            switch (format)
            {
                case "text":
                    //do something
                    TextWriter tw = new TextWriter();
                    article = tw.Write(this);
                    break;
                case "json":
                    JsonWriter jw = new JsonWriter();
                    article = jw.Write(this);
                break;
                default:
                    Console.WriteLine("this format is not supported");
                    break;
            }

            return article;

        }
        */
    }
}
