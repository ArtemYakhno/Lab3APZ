using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Devices;
namespace Main.Users
{
    public class User
    {
        string viaComputer = " via Computer";
        string viaLaptop = " via Laptop";
        string viaSmartphone = " via Smartphone";
        public void watchVideo(object inputObject, int time, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { Console.WriteLine(smartphone.watchVideo(time)+viaSmartphone) ; }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { Console.WriteLine(computer.watchVideo(time)+viaComputer); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { Console.WriteLine(laptop.watchVideo(time)+viaLaptop); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
           
        }
        public void playVideoGames(object inputObject, int time, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { Console.WriteLine(smartphone.playVideoGames(time)+viaSmartphone); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { Console.WriteLine(computer.playVideoGames(time) + viaComputer); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { Console.WriteLine(laptop.playVideoGames(time) + viaLaptop); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void listenMusic(object inputObject, int time, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { Console.WriteLine(smartphone.listenMusic(time) + viaSmartphone); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { Console.WriteLine(computer.listenMusic(time) + viaComputer); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { Console.WriteLine(laptop.listenMusic(time) + viaLaptop); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void work(object inputObject, int time, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { Console.WriteLine(smartphone.work(time) + viaSmartphone); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { Console.WriteLine(computer.work(time) + viaComputer); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { Console.WriteLine(laptop.work(time) + viaLaptop); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void recharching(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.rechargingBattery(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.rebootSystem(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.rechargingBattery(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void getInfoAboutDiveces(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { Console.WriteLine(smartphone.ToString()); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { Console.WriteLine(computer.ToString()); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { Console.WriteLine(laptop.ToString()); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void addHeadphone(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.addComponentOfHeadphone(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.addComponentOfHeadphone(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.addComponentOfHeadphone(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void addNetwork(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.addComponentOfNetwork(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.addComponentOfNetwork(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.addComponentOfNetwork(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void addOperatingSystem(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.addComponentOfOperatingSystem(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.addComponentOfOperatingSystem(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.addComponentOfOperatingSystem(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }       
        public void addComputerMouse(object inputObject, Computer computer, Laptop laptop)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.addComponentOfComputerMouse(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.addComponentOfComputerMouse(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void addKeyboard(object inputObject, Computer computer, Laptop laptop)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.addComponentOfKeyboard(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.addComponentOfKeyboard(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void addGraphicCard(Computer computer)
        {
            try { computer.addComponentOfGraphicCard(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void addMonitor(Computer computer)
        {
            try { computer.addComponentOfMonitor(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void addSpeakers(Computer computer)
        {
            try { computer.addComponentOfSpeakers();}
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }        
        public void addMicrophone(Computer computer)
        {
            try { computer.addComponentOfMicrophone(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void offDeviceEnergy(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.offEnergy(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.offEnergy(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.offEnergy(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void onDeviceEnergy(object inputObject, Computer computer, Laptop laptop, Smartphone smartphone)
        {
            Type typeOfObject = inputObject.GetType();
            try
            {
                if (Object.ReferenceEquals(typeOfObject, smartphone.GetType())) { smartphone.onEnergy(); }
                else if (Object.ReferenceEquals(typeOfObject, computer.GetType())) { computer.onEnergy(); }
                else if (Object.ReferenceEquals(typeOfObject, laptop.GetType())) { laptop.onEnergy(); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public int inputTime()
        {
            int data;
            try
            {
                data = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Incorect data");
            }           
            return data;
        }
     
    }
}
