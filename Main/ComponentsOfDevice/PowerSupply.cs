using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;
namespace Main.ComponentsOfDevice
{
    public class PowerSupply : IChargebel
    {
        protected int chargePowerNow;
        protected double leftTimeCharge;
        protected int powerСapacity;
        protected int chargingPercentage;
        protected string corectFormatOfLeftTimeCharge;
        public PowerSupply(int chargePower)
        {
            this.chargePowerNow = chargePower;
            powerСapacity = chargePowerNow;            
            chargingPercentage = 100;
        }
        public int getChargeBatteryNow()
        {
            return chargePowerNow;
        }
        public int getChargingPercentage()
        {
            return chargingPercentage;
        }
        public string getCorectFormatOfLeftTimeCharge()
        {
            transformateChargeTimeLeft();
            return corectFormatOfLeftTimeCharge;
        }
        public void rechargingBattery()//підзарядка присторою
        {
            chargePowerNow = powerСapacity;
            chargingPercentage = 100;
        }
        public void usingEnergy(int time, int requiredСharge)//використання пристрою
        {
            countingEnergiesOverTime(time, requiredСharge);
            calculatePercentageOfCharge();
            calculateChargeTimeLeft();
        }
        public void countingEnergiesOverTime(int time, int requiredСharge)//підрахунок необхідної енергій за певний час
        {
            chargePowerNow -= time * requiredСharge;
        }
        public void calculatePercentageOfCharge()//підрахунок  відсотку зарядки
        {
            int temp = 100 * chargePowerNow;
            chargingPercentage =  temp / powerСapacity;
        }
        public void calculateChargeTimeLeft() //підрахунок залишку часу.
        {            
            leftTimeCharge = (chargingPercentage * leftTimeCharge) / 100;
        }
        public virtual void transformateChargeTimeLeft() { }//транформація залишку часу в год/хв формат.              
    }
}
