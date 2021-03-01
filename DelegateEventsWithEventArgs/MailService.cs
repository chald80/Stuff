using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEventsWithEventArgs
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            //because to string method is implemented in Video class therefore e.Video will print Title and author
            Console.WriteLine($"MailService: Sending an email .... {e.Video} is encoded");
        }
    }
}
