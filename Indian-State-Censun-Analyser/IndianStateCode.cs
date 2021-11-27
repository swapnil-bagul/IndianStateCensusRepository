using System;
using System.Collections.Generic;
using System.Text;

namespace Indian_State_Censun_Analyser
{
    public class IndianStateCode
    {
        //variables
        public string stateName;
        public string stateCode;
        public int tin;
        public int serialNumber;

        public IndianStateCode(string serialNumber, string stateName, string tin, string stateCode)
        //public IndianStateCode(string stateName, string stateCode, string tin, string serialNumber)
        {
            this.stateName = stateName;
            this.stateCode = stateCode;
            this.tin = Convert.ToInt32(tin);
            this.serialNumber = Convert.ToInt32(serialNumber);
        }
    }
}
