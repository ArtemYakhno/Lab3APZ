using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Headphone
    {
        private bool isHeadphoneExist = false;
        public Headphone(bool isHeadphoneExist)
        {
            this.isHeadphoneExist = isHeadphoneExist;
        }
        public bool getIsHeadphoneExist()
        {
            return isHeadphoneExist;
        }
        public void addHeadphone()
        {
            if (isHeadphoneExist == true) { throw new Exception("You have already headphone"); }
            else { isHeadphoneExist = true; }
        }
    }
}
