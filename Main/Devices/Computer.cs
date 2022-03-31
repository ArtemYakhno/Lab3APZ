using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.ComponentsOfDevice;
using Main.Interfaces;
namespace Main.Devices
{
    public class Computer : Device
    {                
        private Keyboard keyboard;              
        private ComputerMouse computerMouse;                        
        private UninterruptiblePowerSupply uninterruptiblePower;
        
        //Білд компонетів********************************************************************************************************************************************************
        public void addMicrophone(Microphone microphone)
        {
            this.microphone = microphone;
        }
        public void addKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }
        public void addSpeakers(Speakers speakers)
        {
            this.speakers = speakers;
        }        
        public void addComputerMouse(ComputerMouse computerMouse)
        {
            this.computerMouse = computerMouse;
        }               
        public void addUninterruptiblePowerSupply(UninterruptiblePowerSupply uninterruptiblePowerSupply)
        {
            this.uninterruptiblePower = uninterruptiblePowerSupply;
        }
        public void addMonitor(Monitor monitor)
        {
            this.monitor = monitor;
        }
        public void addGraphicCard(GraphicCard graphicCard)
        {
            this.graphicCard = graphicCard;
        }
        //*************************************************************************************************************************************************************

        //ДОДАВАННЯ КОМПОНЕТІВ************************************************************************************************************************************************************      
        public void addComponentOfComputerMouse() { computerMouse.addComputerMouse(); }
        public void addComponentOfKeyboard() { keyboard.addKeyboard(); }        
        public void addComponentOfMonitor() { monitor.addMonitor(); }       
        public void addComponentOfGraphicCard() { graphicCard.addGrapicCard(); }
        public void addComponentOfMicrophone() { microphone.addMicrophone(); }
        public void addComponentOfSpeakers() { speakers.addSpeakers(); }
        //************************************************************************************************************************************************************

        //ПЕРЕВІРКА ПЕРЕЗАПИСАНИХ ФУНКЦІЙ НА ПРАЦЕЗДЕТНІСТЬ ФУНКЦІЙ ПРИСТРОЇВ******************************************************************************************
        public override bool opportunityToWork(int time)
        {
            if (checkEnergy(time, 20) == true) { return (opportunityToKeyboard() && opportunityToComputerMouse()) && opportunityToOS() && opportunityToMonitor(); }
            else { return false;}
        }
        public override bool opportunityToListenMusic(int time)
        {
            if (checkEnergy(time, 40) == true)
            {
                return (opportunityToComputerMouse()) && (opportunityToHeadphone() || opportunityToSpeakers()) && (opportunityToOS() && opportunityToMonitor());
            }
            else { return false; }
        }
        public override bool opportunityToPlayVideoGames(int time)
        {
            if (checkEnergy(time, 100) == true)
            {
                return (opportunityToKeyboard() && opportunityToComputerMouse()) && (opportunityToNetWork() && opportunityToOS()) && (opportunityToHeadphone() || opportunityToSpeakers()) &&
                   (opportunityToMonitor() && opportunityToMicrophone() && opportunityToGPU());
            }
            else { return false; }                
        }
        public override bool opportunityToWatch(int time)
        {
            if (checkEnergy(time, 30) == true)
            {
                return (opportunityToKeyboard() && opportunityToComputerMouse()) && opportunityToNetWork() && (opportunityToHeadphone() || opportunityToSpeakers()) &&
                   (opportunityToMonitor() && opportunityToGPU());
            }
            else { return false; }                
        }
        //******************************************************************************************************************************************************************

        //ПЕРЕВІРКА КОМПОНЕТІВ ************************************************************************************************************************************************   
        private bool opportunityToKeyboard()
        {
            if (keyboard.getIsKeyboardExist() == true) { return true; }
            else { throw new Exception("You don't have keyboard"); }
        }
        private bool opportunityToComputerMouse()
        {
            if (computerMouse.getIsComputerMouseExist() == true) { return true;}
            else { throw new Exception("You don't have computer mouse"); }
        }
        //***************************************************************************************************************************************************************************

        //ПЕРЕВІРКА ЕНЕРГІЙ************************************************************************************************************************************************************************
        public override bool checkEnergy(int time, int charge)
        {
            if (energy.getIsEnergyExist() == false)
            {
                if (uninterruptiblePower.getChargeBatteryNow() >= charge * time) { UseEnergy(time, charge); return true; }
                else { throw new Exception("You dont have enoght energy, restart system"); }
            }
            else { return true; }           
        }
        public override void UseEnergy(int time, int charge)
        {
            uninterruptiblePower.usingEnergy(time, charge);
        }
        ////************************************************************************************************************************************************************************
        public void rebootSystem() { uninterruptiblePower.rechargingBattery(); }//перезапуск системи для відовлення блока ексреного живлення      
        public override string ToString()
        {
            return $"Info about Computer\n" +
                $"Procesor: Name:{procesor.getProcesorName()}\n" +
                $"Memory: Type:{memory.getMemoryType()}  Data Storage:{memory.getMemoryDataStorage()}\n" + 
                $"Grapic card: Exist:{graphicCard.getIsGraphicCardExist().ToString()}\n" + 
                $"Uninterruptible Power Supply: You have:{uninterruptiblePower.getChargingPercentage()} You have yet{uninterruptiblePower.getCorectFormatOfLeftTimeCharge()}\n" +
                $"Monitor:Exist:{monitor.getisMonitorExist().ToString()}\n" + 
                $"Computer Mouse:Exist:{computerMouse.getIsComputerMouseExist().ToString()}\n" +  
                $"Keyboard:Exist:{keyboard.getIsKeyboardExist().ToString()} \n" + 
                $"Microphone:Exist:{microphone.getIsMicrophoneExist().ToString()}\n" + 
                $"Speakers:Exist:{speakers.getIsSpeakersExist().ToString()} \n" + 
                $"Headphone:Exist:{headphone.getIsHeadphoneExist().ToString()}\n" + 
                $"Operating System:Exist:{operatingSystemDevice.getIsOperatingSystemExist().ToString()}\n" + 
                $"Network:Exist:{network.getisNetworkExist().ToString()}\n" + 
                $"Energy:Exist:{energy.getIsEnergyExist().ToString()}\n";              
        }
    }
}
