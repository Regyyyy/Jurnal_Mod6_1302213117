using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213117
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int tambah)
        {
            playCount += tambah;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID         : " + id);
            Console.WriteLine("Title      : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }


}
