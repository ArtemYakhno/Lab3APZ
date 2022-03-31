using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Main.ComponentsOfDevice
{
    public class Battery : PowerSupply
    {
        public Battery(int chargePower ): base(chargePower)
        {            
            if (powerСapacity < 5000) { leftTimeCharge = 12; }
            else { leftTimeCharge = 48; }            
        }
        public override void transformateChargeTimeLeft()//транформація залишку часу в год/хв формат.
        {
            int hour = 0;
            double minutes = 0;
            int allminutes = 0;
            allminutes = Convert.ToInt32(leftTimeCharge * 60);
            minutes = calcutaMinutes(minutes, allminutes);
            hour = calcutaHour(allminutes);
            corectFormatOfLeftTimeCharge = $"Hour {Convert.ToString(hour)}: Minutes {Convert.ToString(minutes)}";
        }
        private double calcutaMinutes(double minutes, int allminutes)//підрахунок хвилин
        {
            minutes = (Convert.ToDouble(allminutes) / 60) - (allminutes / 60);
            minutes *= 60;
            return minutes;
        }
        private int calcutaHour(int allminutes)//підрахунок годин
        {
            return allminutes / 60;
        }
    }
}
 