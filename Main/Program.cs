using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Bilder;
using Main.Devices;
using Main.Users;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {          
            Menu menu = new Menu();
            menu.programMenu();
            Console.ReadKey();
        }
    }
}
