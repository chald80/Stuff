using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using ConsoleSpecialKey = System.ConsoleSpecialKey;

namespace DelegateEventsWithEventArgs
{
    public class VideoEncoder
    {
        //1. Define a delegate i.e the contract/agreement
        //2. Define an Event based on this delegate
        //3. Raise the Event

        //1. Define a delegate i.e the contract/agreement
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);

        //2. Define an Event based on this delegate
        public event VideoEncodedEventHandler VideoEncoded;
        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video});
            }

            ////this does the same as above
            //if (VideoEncoded != null)
            //{

            //    /* VideoEventArgs v = new VideoEventArgs();
            //     v.Video = video;
            //     VideoEncoded(this, v);
            //    */
            //    //ovenstående kan skrives også som følgende
            //    VideoEncoded(this, new VideoEventArgs() { Video = video });
            //}
            //VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});
        }
    }
}
