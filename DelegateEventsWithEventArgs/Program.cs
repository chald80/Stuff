using System;

namespace DelegateEventsWithEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1", Auther = "Aleksander"};
            VideoEncoder videoEncoder = new VideoEncoder(); //publisher
            MailService mailService = new MailService(); //subscriber
            MessageService messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
