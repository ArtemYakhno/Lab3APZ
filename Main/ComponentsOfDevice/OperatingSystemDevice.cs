using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class OperatingSystemDevice
    {        
        private bool isOperatingSystemExist;
        public OperatingSystemDevice(bool isOperatingSystemExist)
        {
            this.isOperatingSystemExist = isOperatingSystemExist;            
        }
        public void addOperatingSystemDevice()
        {
            if (isOperatingSystemExist == true) { throw new Exception("You have already OS"); }
        }
        public bool getIsOperatingSystemExist()
        {
            return isOperatingSystemExist;
        }      
    }
}
