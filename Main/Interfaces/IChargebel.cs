using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    public interface IChargebel
    {
        void usingEnergy(int time, int requiredСharge);
        void countingEnergiesOverTime(int time, int requiredСharge);
        void calculatePercentageOfCharge();
        void calculateChargeTimeLeft();
        void transformateChargeTimeLeft();
    };
    public interface IWatchebel
    {
        string watchVideo(int time);
    };
    public interface IPlayebel
    {
        string playVideoGames(int time);
    };
    public interface IListenebel
    {
        string listenMusic(int time);
    };
    public interface IWorkingbel
    {
        string work(int time);
    };
}
