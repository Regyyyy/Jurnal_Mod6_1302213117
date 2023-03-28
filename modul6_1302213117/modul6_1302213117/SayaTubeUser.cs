using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213117
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        public string Username;

        public SayaTubeUser(string Username)
        {
            Random random = new Random();
            id = random.Next(10000, 100000);
            uploadedVideo = new List<SayaTubeVideo>();
            this.Username = Username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideo) {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + Username);
            int i = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                i++;
                Console.WriteLine("Video "+i+" : " + video.GetTitle());
            }
        }
    }
}
