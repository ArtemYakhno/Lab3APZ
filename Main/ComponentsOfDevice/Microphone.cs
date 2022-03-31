using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Microphone
    {
        private bool isMicrophoneExist = false;
        public Microphone(bool  isMicrophoneExist)
        {
            this.isMicrophoneExist = isMicrophoneExist;
        }
        public bool getIsMicrophoneExist()
        {
            return isMicrophoneExist;
        }
        public void addMicrophone()
        {
            if (isMicrophoneExist == true) { throw new Exception("You have already microphone"); }
            else { isMicrophoneExist = true; }
        }
    }
}
