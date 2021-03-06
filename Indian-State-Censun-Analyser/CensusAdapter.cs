using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Indian_State_Censun_Analyser
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            string[] censusData;
            //checking file is exist or not
            if (!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);

            }
            if (Path.GetExtension(csvFilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid File type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);

            }
            censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return censusData;


        }
    }
}
