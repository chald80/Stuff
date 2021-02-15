using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp
{
    class Factory
    {
        public IWriter GetWriter(string format)//"text" => "T + ext + Writer = TextWriter
        {
            string className = format.First().ToString().ToUpper() + format.Substring(1) + "Writer";
            string namespacePlusClassname = typeof(IWriter).Namespace + "." + className; //ArticleApp.TextWriter

            try
            {
                return (IWriter) Activator.CreateInstance(Type.GetType(namespacePlusClassname));//new TextWriter();
            }
            catch (Exception e)
            {
                throw new NotSupportedException("This format is not supported");
            }


        }
    }
}
