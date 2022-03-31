using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Energy
    {
        private bool isEnergyExist = true;
        public Energy(bool isEnergyExist)
        {
            this.isEnergyExist = isEnergyExist;
        }
        public bool getIsEnergyExist()
        {
            return isEnergyExist;
        }
        public void oofEnergy()
        {
            if (isEnergyExist == false) { throw new Exception("You have already oof energy"); }
            else { isEnergyExist = true; }
        }
        public void onEnergy()
        {
            if (isEnergyExist == true) { throw new Exception("You have already on energy");   }
            else { isEnergyExist = true; }
        }
    }
}
