using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LAB7
{
    interface IRadioPlayerInterface
    {
         void Switch(bool on); 
         void retune(double frequency); 
         void setVolume(int loudness); 
         void changeChannel();

    }
}
