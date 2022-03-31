using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Devices;
namespace Main.Bilder
{
    public class Technician
    {
        public Computer computer = new Computer();
        public Smartphone smartphone = new Smartphone();
        public Laptop laptop = new Laptop();
        public void createComputer(IBuilder builder, 
            bool isComputerMouseExist, bool isKeyboardExist, bool isMicrophoneExist,
            bool isHeadphoneExist, bool isMonitorExist, bool isSpeakersExist,
            string procesorName, string memoryType, int memoryDataStorage,
            int chargeUninterruptiblePowerSupplyNow, bool isEnergyExist,
            bool isNetworkExis, bool isOperatingSystemExist, bool isGPUExist)
        {
            //input
            builder.addComputerMouse(isComputerMouseExist,computer,computer,laptop,smartphone);
            builder.addKeyboard(isKeyboardExist, computer, computer, laptop, smartphone);
            builder.addMicrophone(isMicrophoneExist, computer, computer, laptop, smartphone);
            //output
            builder.addHeadphone(isHeadphoneExist, computer, computer, laptop, smartphone);
            builder.addMonitor(isMonitorExist, computer, computer, laptop, smartphone);
            builder.addSpeakers(isSpeakersExist, computer, computer, laptop, smartphone);
            //Main component
            builder.addProcesor(procesorName, computer, computer, laptop, smartphone);
            builder.addMemory(memoryType,memoryDataStorage, computer, computer, laptop, smartphone);           
            //energy
            builder.addUninterruptiblePowerSupply(chargeUninterruptiblePowerSupplyNow);
            builder.addEnergy(isEnergyExist, computer, computer, laptop, smartphone);
            //another
            builder.addNetwork(isNetworkExis, computer, computer, laptop, smartphone);
            builder.addOperatingSystemDevice(isOperatingSystemExist, computer, computer, laptop, smartphone);                                              
            builder.addGraphicCard(isGPUExist, computer, computer, laptop, smartphone);
        }
        public void createLaptop(IBuilder builder,
            bool isComputerMouseExist, bool isKeyboardExist, bool isMicrophoneExist,
            bool isHeadphoneExist, bool isMonitorExist, bool isSpeakersExist,
            string procesorName, string memoryType, int memoryDataStorage, int chargePower, bool isGPUExist,
            bool isEnergyExist,
            bool isNetworkExis, bool isOperatingSystemExist)
        {
            //input
            builder.addComputerMouse(isComputerMouseExist, laptop, computer, laptop, smartphone);
            builder.addKeyboard(isKeyboardExist, laptop, computer, laptop, smartphone);
            builder.addMicrophone(isMicrophoneExist, laptop, computer, laptop, smartphone);
            //output
            builder.addHeadphone(isHeadphoneExist, laptop, computer, laptop, smartphone);
            builder.addMonitor(isMonitorExist, laptop, computer, laptop, smartphone);
            builder.addSpeakers(isSpeakersExist, laptop, computer, laptop, smartphone);
            //Main component
            builder.addProcesor(procesorName, laptop, computer, laptop, smartphone);
            builder.addMemory(memoryType, memoryDataStorage, laptop, computer, laptop, smartphone);
            builder.addBattery(chargePower, laptop, laptop, smartphone);
            builder.addGraphicCard(isGPUExist, laptop, computer, laptop, smartphone);
            //energy
            builder.addEnergy(isEnergyExist, laptop, computer, laptop, smartphone);
            //another            
            builder.addNetwork(isNetworkExis, laptop, computer, laptop, smartphone);
            builder.addOperatingSystemDevice(isOperatingSystemExist, laptop, computer, laptop, smartphone);            
        }
        public void createSmartphone(IBuilder builder,
            bool isMicrophoneExist,
            bool isHeadphoneExist, bool isMonitorExist, bool isSpeakersExist,
            string procesorName, string memoryType, int memoryDataStorage, int chargePower, bool isGPUExist,
            bool isEnergyExist,
            bool isNetworkExis, bool isOperatingSystemExist)
        {
            //input            
            builder.addMicrophone(isMicrophoneExist, smartphone, computer, laptop, smartphone);
            //output
            builder.addHeadphone(isHeadphoneExist, smartphone, computer, laptop, smartphone);
            builder.addMonitor(isMonitorExist, smartphone, computer, laptop, smartphone);
            builder.addSpeakers(isSpeakersExist, smartphone, computer, laptop, smartphone);
            //Main component
            builder.addProcesor(procesorName, smartphone, computer, laptop, smartphone);
            builder.addMemory(memoryType, memoryDataStorage, smartphone, computer, laptop, smartphone);
            builder.addBattery(chargePower, smartphone, laptop, smartphone);
            builder.addGraphicCard(isGPUExist, smartphone, computer, laptop, smartphone);
            //energy
            builder.addEnergy(isEnergyExist, smartphone, computer, laptop, smartphone);
            //another
            builder.addNetwork(isNetworkExis, smartphone, computer, laptop, smartphone);
            builder.addOperatingSystemDevice(isOperatingSystemExist, smartphone, computer, laptop, smartphone);            
        }
    }
}
