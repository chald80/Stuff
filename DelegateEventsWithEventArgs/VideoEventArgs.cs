using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEventsWithEventArgs
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
