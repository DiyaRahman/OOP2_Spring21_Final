using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    class Player : Phone, IMusicPlayerInterface
    {
        public string PlayerName { get; set; }
        MusicFile music { get; set; }
        public Player(string PlayerName, MusicFile music)
        {
            this.PlayerName = PlayerName;
            this.music = music;
        }
        public override void Switch(bool on)
        {
            if(on)
            {
                base.findMusic(music.title);
            }
            else
            {
                Console.WriteLine("Stop Music");
            }
                
        }
        public override void play(bool on)
        {
            if (on)
            {
                findMusic(music.title);
            }
            else
            {
                Console.WriteLine("Stop Music");
            }
        }
        public override void setVolume(int loudness)
        {

        }
        public override void playNext()
        {
            playNextSong(music.title);
        }
        public override void playPrevious()
        {
            playPreviousSong(music.title);
        }


    }
}
