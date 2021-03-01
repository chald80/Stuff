using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEventsWithEventArgs
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a text message ....{e.Video.Title} is encoded");
        }
    }
}
