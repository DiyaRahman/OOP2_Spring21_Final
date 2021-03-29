using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    class MusicFile
    {
        public string title { get; set; }
        private string artist { get; set; }
        private int yearOfRelease { get; set; }
        private int durationInSeconds {get;set;}

        public MusicFile() { }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine("Title: " +title);
            Console.WriteLine("Artist: " +artist);
            Console.WriteLine("YearOfRelease: " +yearOfRelease);
            Console.WriteLine("DurationInSeconds: " +durationInSeconds);
        }
        
    }
    
}
