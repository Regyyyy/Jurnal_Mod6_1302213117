using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            //Predisposition #5 & #6
            Debug.Assert(Username.Length < 100 && Username != null, "Username tidak valid");

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
            //Predisposition #7 & #8
            Debug.Assert(video != null && video.GetPlayCount() <= int.MaxValue,"Video tidak valid");

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

            //Postcondition
            Debug.Assert(i < 9, "Kelebihan print");
        }
    }
}
