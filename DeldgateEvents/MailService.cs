using System;
using System.Collections.Generic;
using System.Text;

namespace DeldgateEvents
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email ....");
        }
    }
}
