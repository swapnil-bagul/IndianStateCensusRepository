using Microsoft.VisualStudio.TestTools.UnitTesting;
using Indian_State_Censun_Analyser;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class Tests
    {
        static string wrongIndiaStateCensusData = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\WrongIndiaStateCensusData.csv";
        static string wrongIndiaStateCode = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\WrongIndiaStateCode.csv";
        static string indiaStateCensusData = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\IndiaStateCensusData.csv";
        static string indiaStateCode = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\WrongIndiaStateCode.csv";
        static string delimiterIndiaStateCensusData = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\DelimiterIndiaStateCensusData.csv";
        static string delimiterIndiaStateCode = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\DelimiterIndiaStateCode.csv";
        static string indiaStateCodeText = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\IndiaStateCode.txt";
        static string indiaStateCensusDataText = @"C:\Users\Swapnil Bagul\source\repos\Indian-State-Censun-Analyser\Indian-State-Censun-Analyser\Files\IndiaStateCensusDAta.txt";
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        /// <summary>
        /// Set up will always run, when any test case is checked.
        /// </summary>
        [TestMethod]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();

        }
        /// <summary>
        /// Test Case 1.1
        /// Getting the count of data in IndiaStateCensusData
        /// </summary>

        [TestMethod ]
        public void GivenIndianCensusDataFile_WhenReturnShouldReturnCensusDataCount()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCensusData, indianStateCensusHeaders);
            //assert
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(29, totalRecord.Count);
        }
        [TestMethod]
        /// <summary>
        /// checking the program for incorrect file name which do not exist
        /// </summary>
        public void GivenWrongIndianCensusDataFile_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, customException.etype);
        }

    }
}
