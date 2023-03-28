using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Predisposition #1 & #2
            Debug.Assert(title.Length < 200 && title != null, "Input tidak valid");
            
            Random random = new Random();
            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int tambah)
        {
            //Predisposition #3 & #4
            Debug.Assert(tambah >= 0 && tambah <= 25000000, "Penambahan tidak valid");
            
            //Exception
            try
            {
                checked
                {
                    playCount += tambah;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
