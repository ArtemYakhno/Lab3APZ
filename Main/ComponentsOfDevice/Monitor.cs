using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Monitor
    {
        private bool isMonitorExist = false;
        public Monitor(bool isMonitorExist)
        {
            this.isMonitorExist = isMonitorExist;
        }
        public bool getisMonitorExist()
        {
            return isMonitorExist;
        }
        public void addMonitor()
        {
            if (isMonitorExist == true) { throw new Exception("You have already monitor"); }
            else { isMonitorExist = true; }
        }
    }
}
