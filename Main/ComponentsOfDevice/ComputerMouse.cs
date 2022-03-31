using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class ComputerMouse
    {
        private bool isComputerMouseExist = false;
        public ComputerMouse(bool isComputerMouseExist)
        {
            this.isComputerMouseExist = isComputerMouseExist;
        }
        public bool getIsComputerMouseExist()
        {
            return isComputerMouseExist;
        }
        public void addComputerMouse()
        {
            if (isComputerMouseExist == true) { throw new Exception("You have already ComputerMouse"); }
            else { isComputerMouseExist = true; }            
        }
    }
}
