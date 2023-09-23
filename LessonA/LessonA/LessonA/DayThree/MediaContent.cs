using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class MediaContent
    {

        public virtual void StartPlayingContent()  //virtual keyword helps the child class to override.
        {
            Console.WriteLine("Start");
        }

        public void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }

        public void PausePlayingContent()
        {
            Console.WriteLine("Pause");

        }
        public void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        public override sealed string ToString() 
        {
            Console.WriteLine("Media TO String");
            return "AudioContent";
        }
    }
    //End of Media Class

    internal class AudioContent: MediaContent
    {
        public override sealed void StartPlayingContent()  //sealed keyword denotes the child class can only inherit,
                                                           //but cannot override. 
        {
            Console.WriteLine("Start");
        }

    }

    internal class VideoContent: AudioContent
    {

    }

    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
    //End of MediaTester Class
}
