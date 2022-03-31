using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Speakers
    {
        private bool isSpeakersExist = false;
        public Speakers(bool isSpeakersExist)
        {
            this.isSpeakersExist = isSpeakersExist;
        }
        public bool getIsSpeakersExist()
        {
            return isSpeakersExist;
        }
        public void addSpeakers()
        {
            if (isSpeakersExist == true) { throw new Exception("You have already Speakers"); }
            else { isSpeakersExist = true; }
        }
    }
}
