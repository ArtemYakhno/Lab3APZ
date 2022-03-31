using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ComponentsOfDevice
{
    public class Memory
    {
        private string memoryType;
        private int memoryDataStorage;
        public Memory(string memoryType, int memoryDataStorage)
        {
            this.memoryType = memoryType;
            this.memoryDataStorage = memoryDataStorage;
        }
        public string getMemoryType()
        {
            return memoryType;
        }
        public int getMemoryDataStorage()
        {
            return memoryDataStorage;
        }        
    }
}
