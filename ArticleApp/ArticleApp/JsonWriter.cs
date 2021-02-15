using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ArticleApp
{
    class JsonWriter : IWriter
    {
        public string Write(Article article)
        {
            return JsonSerializer.Serialize(article);
        }
    }
}
