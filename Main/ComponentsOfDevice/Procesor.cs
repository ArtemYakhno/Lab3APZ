using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Procesor
    {
        private string procesorName;
        public Procesor(string procesorName)
        {
            this.procesorName = procesorName;
        }
        public string getProcesorName()
        {
            return procesorName;
        }
    }
}
