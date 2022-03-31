using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Devices;
namespace Main.Bilder
{    
    
    public interface IBuilder
    {        
        void addMemory(string memoryType, int memoryDataStorage, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addProcesor(string procesorName, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addMonitor(bool isMonitorExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addKeyboard(bool isKeyboardExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addComputerMouse(bool isComputerMouseExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addHeadphone(bool isHeadphoneExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addMicrophone(bool isMicrophoneExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addGraphicCard(bool isGPUExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addNetwork(bool isNetworkExis, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addOperatingSystemDevice(bool isOperatingSystemExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addUninterruptiblePowerSupply(int chargeUninterruptiblePowerSupplyNow);
        void addBattery(int chargePower, object inputObject, Laptop laptop, Smartphone smartphone);
        void addSpeakers(bool isSpeakersExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
        void addEnergy(bool isEnergyExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone);
    }
}
