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
            Console.WriteLine("\nTotal play count pada playlist : "+playlist.GetTotalVideoPlayCount());
            playlist.PrintAllVideoPlaycount();
        }
    }
}


