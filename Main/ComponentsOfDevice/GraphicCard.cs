using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class GraphicCard
    {       
        private bool isGPUExist = false;
        public GraphicCard(bool isGPUExist)
        {            
            this.isGPUExist = isGPUExist;
        }       
        public bool getIsGraphicCardExist()
        {
            return isGPUExist;
        }
        public void addGrapicCard()
        {
            if (isGPUExist == true) { throw new Exception("You have already grapic card"); }
            else { isGPUExist = true; }
 
        }
    }
}
