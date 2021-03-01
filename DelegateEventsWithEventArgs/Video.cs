using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEventsWithEventArgs
{
    public class Video
    {
        public string Title { get; set; }
        public string Auther { get; set; }

        public override string ToString()
        {
            return $" {Title} {Auther}";
        }
    }
}
