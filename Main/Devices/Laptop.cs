using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.ComponentsOfDevice;
namespace Main.Devices
{
    public class Laptop:Device
    {                
        private Keyboard keyboard;                
        private ComputerMouse computerMouse;                             
        private Battery battery;
        
        public Laptop() { }
        //Білд компонетів************************************************************************************************************************************************
        public void addMicrophone(bool isMicrophoneExist)
        {
            this.microphone = new Microphone(isMicrophoneExist);
        }
        public void addKeyboard(bool isKeyboardExist)
        {
            this.keyboard = new Keyboard(isKeyboardExist);
        }
        public void addSpeakers(bool isMicrophoneExist)
        {
            this.speakers = new Speakers(isMicrophoneExist);
        }        
        public void addComputerMouse(bool isComputerMouseExist)
        {
            this.computerMouse = new ComputerMouse(isComputerMouseExist);
        }                  
        public void addBattery(int chargePower)
        {
            this.battery = new Battery(chargePower);
        }
        public void addGraphicCard(bool isGPUExist)
        {
            this.graphicCard = new GraphicCard(isGPUExist);
        }       
        public void addMonitor(bool isMonitorExist)
        {
            this.monitor = new Monitor(isMonitorExist);
        }
        //***************************************************************************************************************************************************************

        //ДОДАВАННЯ КОМПОНЕТІВ************************************************************************************************************************************************************      
        public void addComponentOfComputerMouse() { computerMouse.addComputerMouse(); }
        public void addComponentOfKeyboard() { keyboard.addKeyboard(); }        
        //************************************************************************************************************************************************************

        //ПЕРЕВІРКА ПЕРЕЗАПИСАНИХ ФУНКЦІЙ НА ПРАЦЕЗДЕТНІСТЬ ФУНКЦІЙ ПРИСТРОЇВ**************************************************************************************************************
        public override bool opportunityToWork(int time)
        {
            if (checkEnergy(time, 20) == true) { return (opportunityToKeyboard() && opportunityToComputerMouse() && opportunityToOS() && opportunityToMonitor()); }
            else { return false; }
        }
        public override bool opportunityToListenMusic(int time)
        {
            if (checkEnergy(time, 40) == true)
            {
                return ((opportunityToComputerMouse()) && (opportunityToHeadphone() || opportunityToSpeakers()) && (opportunityToOS() && opportunityToMonitor()));
            }
            else { return false; }
        }
        public override bool opportunityToPlayVideoGames(int time)
        {
            if (checkEnergy(time, 100) == true)
            {
                return ((opportunityToKeyboard() && opportunityToComputerMouse()) && (opportunityToNetWork() && opportunityToOS()) && (opportunityToHeadphone() || opportunityToSpeakers()) &&
                   (opportunityToMonitor() && opportunityToMicrophone() && opportunityToGPU()));
            }
            else { return false; }

        }
        public override bool opportunityToWatch(int time)
        {
            if (checkEnergy(time, 20) == true)
            {
                return ((opportunityToKeyboard() && opportunityToComputerMouse()) && opportunityToNetWork() && (opportunityToHeadphone() || opportunityToSpeakers()) &&
                   (opportunityToMonitor() && opportunityToGPU()));
            }
            else { return false; }

        }
        //********************************************************************************************************************************************************************************

        //ПЕРЕВІРКА КОМПОНЕТІВ************************************************************************************************************************************************ 
        private bool opportunityToKeyboard()
        {
            if (keyboard.getIsKeyboardExist() == true) { return true; }
            else { throw new Exception("You don't have keyboard"); }
        }
        private bool opportunityToComputerMouse()
        {
            if (computerMouse.getIsComputerMouseExist() == true) { return true; }
            else { throw new Exception("You don't have keyboard"); }
        }
        //********************************************************************************************************************************************************************** 

        //ПЕРЕВІРКА ЕНЕРГІЙ**************************************************************************************************************************************************************
        public override bool checkEnergy(int time, int charge)
        {
            if (energy.getIsEnergyExist() == false)
            {
                if (battery.getChargeBatteryNow() >= charge*time) { UseEnergy(time, charge); return true; }
                else { throw new Exception("You dont have enoght energy, restart system"); }
            }
            else { return true; }
        }
        public override void UseEnergy(int time, int charge) { battery.usingEnergy(time, charge); }
        //************************************************************************************************************************************************************************************************        
        public void rechargingBattery() { battery.rechargingBattery(); }//підзарядка батареї

        public override string ToString()
        {
            return $"Info about Laptop\n" +
                $"Procesor: Name:{procesor.getProcesorName()}\n" +
                $"Memory: Type:{memory.getMemoryType()}  Data Storage:{memory.getMemoryDataStorage()}\n" +
                $"Grapic card: Exist:{graphicCard.getIsGraphicCardExist().ToString()}\n" +
                $"Battery: You have:{battery.getChargingPercentage()}% You have yet {battery.getCorectFormatOfLeftTimeCharge()}\n" +
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
