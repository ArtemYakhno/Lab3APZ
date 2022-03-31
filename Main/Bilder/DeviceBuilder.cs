using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Devices;
using Main.ComponentsOfDevice;
namespace Main.Bilder
{
    public class DeviceBuilder : IBuilder
    {
        public Computer computer = new Computer();
        public Smartphone smartphone = new Smartphone();
        public Laptop laptop = new Laptop();
        public DeviceBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this.computer = new Computer();
            this.smartphone = new Smartphone();
            this.laptop = new Laptop();
        }
        public Computer GetComputer()
        {
            Computer result = this.computer;
            this.reset();
            return result;
        }
        public Laptop GetLaptop()
        {
            Laptop result = this.laptop;
            this.reset();
            return result;
        }
        public Smartphone GetSmartphone()
        {
            Smartphone result = this.smartphone;
            this.reset();
            return result;
        }
        public void addHeadphone(bool isHeadphoneExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Headphone headphone = new Headphone(isHeadphoneExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addHeadphone(headphone); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addHeadphone(headphone); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addHeadphone(headphone); }
        }

        public void addNetwork(bool isNetworkExis, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Network network = new Network(isNetworkExis);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addNetwork(network); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addNetwork(network); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addNetwork(network); }

        }

        public void addOperatingSystemDevice(bool isOperatingSystemExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            OperatingSystemDevice operatingSystemDevice = new OperatingSystemDevice(isOperatingSystemExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addOperatingSystemDevice(operatingSystemDevice); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addOperatingSystemDevice(operatingSystemDevice); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addOperatingSystemDevice(operatingSystemDevice); }
        }
        public void addMemory(string memoryType, int memoryDataStorage, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addMemory(memoryType, memoryDataStorage); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addMemory(memoryType, memoryDataStorage); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addMemory(memoryType, memoryDataStorage); }
        }
        public void addProcesor(string procesorName, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addProcesor(procesorName); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addProcesor(procesorName); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addProcesor(procesorName); }

        }
        public void addMonitor(bool isMonitorExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Monitor monitor = new Monitor(isMonitorExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addMonitor(isMonitorExist); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addMonitor(monitor); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addMonitor(isMonitorExist); }

        }
        public void addKeyboard(bool isKeyboardExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Keyboard keyboard = new Keyboard(isKeyboardExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addKeyboard(keyboard); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addKeyboard(isKeyboardExist); }

        }
        public void addComputerMouse(bool isComputerMouseExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            ComputerMouse computerMouse = new ComputerMouse(isComputerMouseExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addComputerMouse(computerMouse); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addComputerMouse(isComputerMouseExist); }

        }
        public void addMicrophone(bool isMicrophoneExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Microphone microphone = new Microphone(isMicrophoneExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addMicrophone(isMicrophoneExist); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addMicrophone(microphone); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addMicrophone(isMicrophoneExist); }

        }
        public void addGraphicCard(bool isGPUExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            GraphicCard graphicCard = new GraphicCard(isGPUExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addGraphicCard(isGPUExist); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addGraphicCard(graphicCard); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addGraphicCard(isGPUExist); }

        }
        public void addUninterruptiblePowerSupply(int chargeUninterruptiblePowerSupplyNow)
        {
            UninterruptiblePowerSupply uninterruptiblePowerSupply = new UninterruptiblePowerSupply(chargeUninterruptiblePowerSupplyNow);
            this.computer.addUninterruptiblePowerSupply(uninterruptiblePowerSupply);
        }
        public void addBattery(int chargePower, object inputObject, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addBattery(chargePower); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addBattery(chargePower); }

        }
        public void addSpeakers(bool isSpeakersExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Speakers speakers = new Speakers(isSpeakersExist);
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addSpeakers(isSpeakersExist); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addSpeakers(speakers); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addSpeakers(isSpeakersExist); }

        }
        public void addEnergy(bool isEnergyExist, object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { this.smartphone.addEnegry(isEnergyExist); }
            else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { this.computer.addEnegry(isEnergyExist); }
            else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { this.laptop.addEnegry(isEnergyExist); }

        }
    }
}
