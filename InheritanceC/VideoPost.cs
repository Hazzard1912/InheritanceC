using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost : Post
    {
        // Member fields
        protected bool isPlaying = false;

        protected int currentDuration = 0;

        Timer timer; // Usaremos timer

        protected string VideoURL { get; set; }

        protected int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendBy, bool isPublic, string videoURL, int length)
            : base(title, sendBy, isPublic)
        {
            VideoURL = videoURL;
            Length = length;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", base.ToString(), VideoURL, Length);
        }

        // Metodo para el timer:

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing the video");
                timer = new Timer(TimerCallback, null, 0, 1000);
                isPlaying = true;
            }
        }

        private void TimerCallback(Object obj)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }
    }
}
