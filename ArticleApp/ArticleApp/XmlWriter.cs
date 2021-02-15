using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ArticleApp
{
    class XmlWriter : IWriter

    {
        public string Write(Article article)
        {
            return $"<xml> <Article><Author>{article.Author}</Author><Title>{article.Title}</Title> </Article>";
        }
    }
}
