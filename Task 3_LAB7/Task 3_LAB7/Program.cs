using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile M1 = new MusicFile("FLY", "Badshah", 2021, 2);
            MusicFile M2 = new MusicFile("Kurta Pajama", "Tony kakkar", 2020, 4);

            

            Phone P1 = new Player("Music", M1);
            P1.Addmusic(M1, M2);
            P1.play(true);
            P1.playNext();
            //P1.playPrevious();

            Console.WriteLine();

            //Phone radio = new RPlayer();


        }
    }
}
