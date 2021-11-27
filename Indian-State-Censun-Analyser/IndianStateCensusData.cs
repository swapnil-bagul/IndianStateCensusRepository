using System;
using System.Collections.Generic;
using System.Text;

namespace Indian_State_Censun_Analyser
{
    public class IndianStateCensusData
    {
        public string state;
        public long population;
        public long area;
        public long density;
        //initialise data
        public IndianStateCensusData(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }
    }
}
