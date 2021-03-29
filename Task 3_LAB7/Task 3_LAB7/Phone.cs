using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    abstract class Phone : IMusicPlayerInterface
    {
        public int totalMusic { get; set; }
        MusicFile[] musicFile;
        public Phone()
        {
            musicFile = new MusicFile[100];
        }
        public void Musiclist()
        {
            for (int i = 0; i < totalMusic; i++)
            {
                this.musicFile[i].ShowInfo();
            }
        }
        public void findMusic(string title) 
        {
            foreach(var music in musicFile)
            {
                if (music.title.Equals(title))
                {
                    Console.WriteLine("Music start");
                    music.ShowInfo();
                    break;

                }
            }
                
        }
        public void Addmusic(params MusicFile[] musics)
        {
            if (totalMusic < 100)
            {
                foreach (MusicFile music in musics)
                {
                    this.musicFile[totalMusic++] = music;
                }

            }
            else
            {
                Console.WriteLine("file cannot add more then 100music file");
            }
        }
        public void playPreviousSong(string title)
        {
            for (int i = 0; i < totalMusic; i++)
            {
                if (i >= 0)
                {
                    if (musicFile[i].title.Equals(title))
                    {
                        findMusic(musicFile[i - 1].title);
                    }

                }
                else
                {
                    Console.WriteLine("Start SONG");
                }
            }
        }
        public void playNextSong(string title)
        {
            for (int i = 0; i < totalMusic; i++)
            {
                if (i < totalMusic)
                {
                    if (musicFile[i].title.Equals(title))
                    {
                        findMusic(musicFile[i + 1].title);
                    }
                }
                else Console.WriteLine("LAST Song");
            }
        }

        public abstract void Switch(bool on);
        public abstract void play(bool on);
        public abstract void setVolume(int loudness);
        public abstract void playNext();
        public abstract void playPrevious();

    }
}
