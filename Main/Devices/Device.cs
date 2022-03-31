using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.ComponentsOfDevice;
using Main.Interfaces;
namespace Main.Devices
{
    public abstract class Device : IWatchebel, IWorkingbel, IPlayebel, IListenebel
    {
        //Main
        protected Memory memory;
        protected Procesor procesor;
        protected Monitor monitor;
        protected Energy energy;
        //Another
        protected Microphone microphone;
        protected Speakers speakers;
        protected Headphone headphone;
        protected Network network;
        protected OperatingSystemDevice operatingSystemDevice;
        protected GraphicCard graphicCard;
        //Білд компонетів******************************************************************************************************************************************************************************
        public void addMemory(string memoryType, int memoryDataStorage)
        {
            this.memory = new Memory(memoryType, memoryDataStorage);            
        }
        public void addProcesor(string procesorName)
        {
            this.procesor = new Procesor(procesorName);
        }
        public void addEnegry(bool isEnergyExist)
        {
            this.energy = new Energy(isEnergyExist);
        }
        public void addHeadphone(Headphone headphone)
        {
            this.headphone = headphone;
        }
        public void addNetwork(Network network)
        {
            this.network = network;
        }
        public void addOperatingSystemDevice(OperatingSystemDevice operatingSystemDevice)
        {
            this.operatingSystemDevice = operatingSystemDevice;
        }

        //Додаваня копмонентів************************************************************************************************************************************************
        public void addComponentOfHeadphone() { headphone.addHeadphone(); }       
        public void addComponentOfNetwork() { network.addNetWork(); }        
        public void addComponentOfOperatingSystem() { operatingSystemDevice.addOperatingSystemDevice(); }
        //************************************************************************************************************************************************

        //ФУНКЦІЙ ОПРАЦЮВАННЯ ІЗ ПК******************************************************************************************************************************************************************************
        public string watchVideo(int time)
        {
            if (opportunityToWatch(time) == true) { return "You are watching video"; }
            else { return "Yoc can't  watching video cause u don't have necessary components"; }

        }
        public string playVideoGames(int time)
        {
            if (opportunityToPlayVideoGames(time) == true) { return "You are playing computer game"; }
            else { return "Yoc can't  playing cause u don't have necessary components"; }

        }
        public string listenMusic(int time)
        {
            if (opportunityToListenMusic(time) == true) { return "You are listening music"; }
            else { return "Yoc can't  listening music cause u don't have necessary components"; }
        }
        public string work(int time)
        {
            if (opportunityToWork(time) == true) { return "You are working!"; }
            else { return "Yoc can't working cause u don't have necessary components"; }
        }
        //******************************************************************************************************************************************************************************

        //Віртуальні методи для перевірки працездості функцій пристроїв********************************************************************************************************************
        public virtual bool opportunityToWork(int time) { return false; }
        public virtual bool opportunityToListenMusic(int time) { return false; }
        public virtual bool opportunityToWatch(int time) { return false; }
        public virtual bool opportunityToPlayVideoGames(int time) { return false; }
        //******************************************************************************************************************************************************************************

        //ПЕРЕВІРКА КОМПОНЕТІВ******************************************************************************************************************************************************************************        
        protected bool opportunityToNetWork()
        {
            if (network.getisNetworkExist() == true) { return true; }
            else { throw new Exception("You don't have NetWork"); }
        }
        protected bool opportunityToOS()
        {
            if (operatingSystemDevice.getIsOperatingSystemExist() == true) { return true; }
            else { throw new Exception("You don't have operating system"); }
        }
        protected bool opportunityToHeadphone()
        {
            if (headphone.getIsHeadphoneExist() == true) { return true; }
            else { throw new Exception("You don't have headphone or speakers"); }
        }
        protected bool opportunityToSpeakers()
        {
            if (speakers.getIsSpeakersExist() == true) { return true; }
            else { throw new Exception("You don't have headphone or speakers"); }
        }
        protected bool opportunityToMonitor()
        {
            if (monitor.getisMonitorExist() == true) { return true; }
            else { throw new Exception("You don't have monitor"); }
        }
        protected bool opportunityToMicrophone()
        {
            if (microphone.getIsMicrophoneExist() == true) { return true; }
            else { throw new Exception("You don't have microphone"); }
        }
        protected bool opportunityToGPU()
        {
            if (graphicCard.getIsGraphicCardExist() == true) { return true; }
            else { throw new Exception("You don't have graphic card"); }
        }
        //******************************************************************************************************************************************************************************

        //ПЕРЕВІРКА ЕНЕРГІЙ******************************************************************************************************************************************************************************
        public virtual bool checkEnergy(int time, int charge) { return true; }      
        public virtual void UseEnergy(int time, int charge) { }
        //******************************************************************************************************************************************************************************

        //Включення і виключення енергій*******************************************************************************************************************************************
        public void offEnergy() { energy.oofEnergy(); }
        public void onEnergy() { energy.onEnergy(); }       
        //*******************************************************************************************************************************************
    }
}
