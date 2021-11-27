using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Indian_State_Censun_Analyser
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusDTO>();
            censusData = GetCensusData(csvFilePath, dataHeaders);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File contains wrong Delimiter", CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER);
                }
                string[] column = data.Split(",");
                if (csvFilePath.Contains("IndianStateCode.csv"))
                {
                    dataMap.Add(column[1], new CensusDTO(new IndianStateCode(column[0], column[1], column[2], column[3])));
                }
                if (csvFilePath.Contains("IndianStateCensusData.csv"))
                {
                    dataMap.Add(column[1], new CensusDTO(new IndianStateCensusData(column[0], column[1], column[2], column[3])));
                }
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
