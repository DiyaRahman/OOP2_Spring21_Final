using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    class RPlayer: Phone, IRadioPlayerInterface
    {

        public string PlayerName { get; set; }
        public double channel { get; set; }
        
        public RPlayer(string PlayerName, double channel)
        { 
            this.PlayerName = PlayerName;
            this.channel = channel;
        }
        public override void Switch(bool on)
        {
            
            Console.WriteLine(" Music");
            ShowInfo();
          

        }
        public override void play(bool on)
        {

            Console.WriteLine("Radio Music");
            ShowInfo();
        }
        public override void setVolume(int loudness)
        {

        }
        public override void playNext()
        {
            if (channel <= 0.10)
            {
                channel = channel + 0.10;
            }
            else
            {
                Console.WriteLine("Cnnot go next");

                ShowInfo();
            }
        }
        public override void playPrevious()
        {
            if (channel >= 0.10)
            {
                channel = channel - 0.10;
            }
            else
            {
                Console.WriteLine("Cnnot go prev");

                ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("channel: " + channel);
        }

        public void retune(double frequency)
        {
            
        }

        public void changeChannel()
        {
            
        }
        
    }
}
