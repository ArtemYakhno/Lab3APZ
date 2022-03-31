using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;
namespace Main.ComponentsOfDevice
{
    public class UninterruptiblePowerSupply : PowerSupply
    {        
        public UninterruptiblePowerSupply(int chargeUninterruptiblePowerSupplyNow): base (chargeUninterruptiblePowerSupplyNow)
        {           
            leftTimeCharge = 30;            
        }               
        public override void transformateChargeTimeLeft()//транформація залишку часу в год/хв формат.
        {            
            double minutes = 0;
            int allminutes = 0;
            allminutes = Convert.ToInt32(leftTimeCharge * 60);
            minutes = calcutaMinutes(allminutes,minutes);           
            corectFormatOfLeftTimeCharge = $"Minutes:{Convert.ToString(minutes)}";
        }
        public double calcutaMinutes(int allminutes,double minutes)//підрахунок хвилин
        {
            minutes = (Convert.ToDouble(allminutes) / 60) - (allminutes / 60);
            minutes *= 60;
            return minutes;
        }        
    }
}
