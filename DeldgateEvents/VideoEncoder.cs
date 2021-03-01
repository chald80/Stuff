using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using ConsoleSpecialKey = System.ConsoleSpecialKey;

namespace DeldgateEvents
{
    public class VideoEncoder
    {
        //1. Define a delegate i.e the contract/agreement
        //2. Define an Event based on this delegate
        //3. Raise the Event

        //1. Define a delegate i.e the contract/agreement
        public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        //2. Define an Event based on this delegate
        public event VideoEncodedEventHandler VideoEncoded;
        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
            //this does the same as above
            //VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
