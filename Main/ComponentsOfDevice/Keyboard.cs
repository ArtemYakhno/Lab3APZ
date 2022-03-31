using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Keyboard
    {
        private bool isKeyboardExist=false;
        public Keyboard(bool isKeyboardExist)
        {
            this.isKeyboardExist = isKeyboardExist;
        }
        public bool getIsKeyboardExist()
        {
            return isKeyboardExist;
        }
        public void addKeyboard()
        {
            if (isKeyboardExist == true) { throw new Exception("You have already keyboard"); }
            else { isKeyboardExist = true; }
        }
    }
}
