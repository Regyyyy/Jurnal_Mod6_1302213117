using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace modul6_1302213117
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //coba class SayaTubeVideo
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Maze oleh Regy Renanda Rahman");
            video1.IncreasePlayCount(10);
            video1.PrintVideoDetails();
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Battle Layang-layang oleh Regy Renanda Rahman");
            video2.IncreasePlayCount(150);

            //coba class SayaTubeUser
            SayaTubeUser playlist = new SayaTubeUser("Regy");
            playlist.AddVideo(video1);
            playlist.AddVideo(video2);
            Console.WriteLine("\nTotal play count pada playlist : "+playlist.GetTotalVideoPlayCount()+"\n");
            playlist.PrintAllVideoPlaycount();

            
            //Coba predisposition #3
            SayaTubeVideo video3 = new SayaTubeVideo("Vlog diriku");
            /*
            video3.IncreasePlayCount(-5);
            */

            //Coba exception
            /*
            for (int i = 0; i < 110; i++)
            {
                video3.IncreasePlayCount(20000000);
            }
            */
            video3.PrintVideoDetails();

            //Coba postcondition
            SayaTubeVideo video4 = new SayaTubeVideo("Review");
            SayaTubeVideo video5 = new SayaTubeVideo("Review");
            SayaTubeVideo video6 = new SayaTubeVideo("Review");
            SayaTubeVideo video7 = new SayaTubeVideo("Review");
            SayaTubeVideo video8 = new SayaTubeVideo("Review");
            SayaTubeVideo video9 = new SayaTubeVideo("Review");
            playlist.AddVideo(video4);
            playlist.AddVideo(video5);
            playlist.AddVideo(video6);
            playlist.AddVideo(video7);
            playlist.AddVideo(video8);
            playlist.AddVideo(video9);
            playlist.AddVideo(video9);
            playlist.PrintAllVideoPlaycount();
        }
    }
}


