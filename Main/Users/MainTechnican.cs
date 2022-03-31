using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Bilder;
using Main.Devices;
using Main.ComponentsOfDevice;
namespace Main.Users
{
    public class MainTechnican
    {
        public Computer createComputer(Technician technician,Computer computer)
        {
            DeviceBuilder builderPC = new DeviceBuilder();
            try
            {               
                technician.createComputer(builderPC, true, true, true, true, true, true, "i9-11400f", "DDR4", 16, 500, true, true, true, true);                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return builderPC.GetComputer(); ;
        }

        public Laptop createLaptop(Technician technician, Laptop laptop)
        {
            DeviceBuilder builderLP = new DeviceBuilder();
            try
            {                
                technician.createLaptop(builderLP, true, true, true, true, true, true, "i10-11400f", "DDR6", 16, 8000, true, false, true, true);
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return builderLP.GetLaptop(); ;

        }

        public Smartphone createSmartphone(Technician technician, Smartphone smartphone)
        {
            DeviceBuilder builderSP = new DeviceBuilder();
            try
            {              
                technician.createSmartphone(builderSP, true, true, true, true, "i9-11400f", "DDR4", 16, 8000, true, true, true, true);                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return builderSP.GetSmartphone(); ;
        }

        public Technician createTechnican()
        {
            Technician technician = new Technician();
            return technician;
        }
    }
}
