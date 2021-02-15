using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp
{
    class TextWriter : IWriter
    {
        public string Write(Article article)
        {
            return $"Title: {article.Title} Author: {article.Author} Date: {article.Date}";
        }
    }
}
