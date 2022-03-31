using Main.Bilder;
using Main.Devices;
using System;
using Main.Users;
namespace Main
{
    public class Menu
    {
        MainTechnican mainTechnican = new MainTechnican();
        User user = new User();
        Technician technician;
        Computer computer ;
        Laptop laptop;
        Smartphone smartphone;
        public void programMenu()
        {
            createObject();
            bool stop = false;           
            while (!stop)
            {
                textChoise("Select the device you want to work with:\n" + "1 - Computer\n" + "2 - Laptop\n" + "3 - Smartphone\n" + "4 - End program");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        computerCommand();
                        break;
                    case 2:
                        laptopCommand();
                        break;
                    case 3:
                        smartphoneCommand();
                        break;
                    case 4:
                        stop = true;
                        Console.WriteLine("Tap any key on the keyboard, to stop program.");
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
        private void computerCommand()
        {
            int time;
            bool stopPC = false;
            while (!stopPC)
            {
                textChoise("Select the action which do you want to do:\n" + "1 - Play video games\n" + "2 - Watch smtgh\n" + "3 - Work\n" + "4 - Listen music\n" +
                "5 - Get info about device\n" + "6 - Reboot system\n" + "7 - Add componet to computer\n" + "8 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        time = inputTimeOfDoing();
                        user.playVideoGames(computer, time, computer, laptop, smartphone);
                        break;
                    case 2:
                        time = inputTimeOfDoing();
                        user.watchVideo(computer, time, computer, laptop, smartphone);
                        break;
                    case 3:
                        time = inputTimeOfDoing();
                        user.work(computer, time, computer, laptop, smartphone);
                        break;
                    case 4:
                        time = inputTimeOfDoing();
                        user.listenMusic(computer, time, computer, laptop, smartphone);
                        break;
                    case 5:
                        user.getInfoAboutDiveces(computer, computer, laptop, smartphone);
                        break;
                    case 6:
                        user.recharching(computer, computer, laptop, smartphone);
                        break;
                    case 7:
                        addComputerComponent();
                        break;
                    case 8:
                        stopPC = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }            
        }
        private void laptopCommand()
        {
            int time;
            bool stopLP = false;
            while (!stopLP)
            {
                textChoise("Select the action which do you want to do:\n" + "1 - Play video games\n" + "2 - Watch smtgh\n" + "3 - Work\n" + "4 - Listen music\n" +
                "5 - Get info about device\n" + "6 - Recharch device\n" +"7 - Add componet to laptop\n" + "8 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        time = inputTimeOfDoing();
                        user.playVideoGames(laptop, time, computer, laptop, smartphone);
                        break;
                    case 2:
                        time = inputTimeOfDoing();
                        user.watchVideo(laptop, time, computer, laptop, smartphone);
                        break;
                    case 3:
                        time = inputTimeOfDoing();
                        user.work(laptop, time, computer, laptop, smartphone);
                        break;
                    case 4:
                        time = inputTimeOfDoing();
                        user.listenMusic(laptop, time, computer, laptop, smartphone);
                        break;
                    case 5:
                        user.getInfoAboutDiveces(laptop, computer, laptop, smartphone);
                        break;
                    case 6:
                        user.recharching(laptop, computer, laptop, smartphone);
                        break;
                    case 7:
                        addLaptopComponent();
                        break;
                    case 8:
                        stopLP = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
        private void smartphoneCommand()
        {
            int time;
            bool stopSP = false;
            while (!stopSP)
            {
                textChoise("Select the action which do you want to do:\n" + "1 - Play video games\n" + "2 - Watch smtgh\n" + "3 - Work\n" + "4 - Listen music\n" +
                "5 - Get info about device\n" + "6 - Recharch device\n" + "7 - Add componet to smartphone\n" + "8 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        time = inputTimeOfDoing();
                        user.playVideoGames(smartphone, time, computer, laptop, smartphone);
                        break;
                    case 2:
                        time = inputTimeOfDoing();
                        user.watchVideo(smartphone, time, computer, laptop, smartphone);
                        break;
                    case 3:
                        time = inputTimeOfDoing();
                        user.work(smartphone, time, computer, laptop, smartphone);
                        break;
                    case 4:
                        time = inputTimeOfDoing();
                        user.listenMusic(smartphone, time, computer, laptop, smartphone);
                        break;
                    case 5:
                        user.getInfoAboutDiveces(smartphone, computer, laptop, smartphone);
                        break;
                    case 6:
                        user.recharching(smartphone, computer, laptop, smartphone);
                        break;
                    case 7:
                        addSmartphoneComponent();
                        break;
                    case 8:
                        stopSP = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }       
        private void addComputerComponent() 
        {           
            bool stopPC = false;
            while (!stopPC)
            {
                textChoise("Select the component which do you want to add:\n" + "1 - Add Headphone\n" + "2 - Add Operating System \n" + "3 - Add Network\n" + "4 - Add Comptuer mouse\n" +
                "5 - Add Keyboard\n" + "6 - Add Monitor\n" + "7 - Add Graphic Card\n" + "8 - Add Microphone\n" + "9 - Add Speakers\n" + "10 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        user.addHeadphone(computer, computer, laptop, smartphone);
                        break;
                    case 2:
                        user.addOperatingSystem(computer, computer, laptop, smartphone);
                        break;
                    case 3:
                        user.addNetwork(computer, computer, laptop, smartphone);
                        break;
                    case 4:
                        user.addComputerMouse(computer, computer, laptop);
                        break;
                    case 5:
                        user.addKeyboard(computer, computer, laptop);
                        break;
                    case 6:
                        user.addMonitor(computer);
                        break;
                    case 7:
                        user.addGraphicCard(computer);
                        break;
                    case 8:
                        user.addMicrophone(computer);
                        break;
                    case 9:
                        user.addSpeakers(computer);
                        break;
                    case 10:
                        stopPC = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
        private void addLaptopComponent()
        {           
            bool stopLP = false;
            while (!stopLP)
            {
                textChoise("Select the component which do you want to add:\n" + "1 - Add Headphone\n" + "2 - Add Operating System \n" + "3 - Add Network\n" + "4 - Add Comptuer mouse\n" +
                "5 - Add Keyboard\n"+ "6 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        user.addHeadphone(computer, computer, laptop, smartphone);
                        break;
                    case 2:
                        user.addOperatingSystem(computer, computer, laptop, smartphone);
                        break;
                    case 3:
                        user.addNetwork(computer, computer, laptop, smartphone);
                        break;
                    case 4:
                        user.addComputerMouse(computer, computer, laptop);
                        break;
                    case 5:
                        user.addKeyboard(computer, computer, laptop);
                        break;                    
                    case 6:
                        stopLP = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
        private void addSmartphoneComponent()
        {
            bool stopSP = false;
            while (!stopSP)
            {
                textChoise("Select the component which do you want to add:\n" + "1 - Add Headphone\n" + "2 - Add Operating System \n" + "3 - Add Network\n"  + "4 - Return to back\n");
                int command = inputComand();
                switch (command)
                {
                    case 1:
                        user.addHeadphone(computer, computer, laptop, smartphone);
                        break;
                    case 2:
                        user.addOperatingSystem(computer, computer, laptop, smartphone);
                        break;
                    case 3:
                        user.addNetwork(computer, computer, laptop, smartphone);
                        break;
                    case 4:                       
                        stopSP = true;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
        private void textChoise(string message)
        {
            Console.WriteLine(message);
        }      
        private int inputComand()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        private void createObject()
        {
            technician = mainTechnican.createTechnican();
            computer = mainTechnican.createComputer(technician, computer);
            laptop = mainTechnican.createLaptop(technician, laptop);
            smartphone = mainTechnican.createSmartphone(technician, smartphone);
        }
        private int inputTimeOfDoing()
        {
            Console.WriteLine("Enter the time during which you will perform this action:");                                 
            return user.inputTime();
        }
    }
}
