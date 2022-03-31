using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Network
    {
        private bool isNetworkExist = false;        
        public Network(bool isNetworkExis)
        {
            this.isNetworkExist = isNetworkExis;           
        }
        public bool getisNetworkExist()
        {
            return isNetworkExist;
        }        
        public void addNetWork()
        {
            if (isNetworkExist == true) { throw new Exception("You have already network"); }                    
        }
    }
}
