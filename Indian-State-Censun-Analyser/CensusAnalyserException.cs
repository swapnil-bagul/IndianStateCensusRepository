using System;
using System.Collections.Generic;
using System.Text;

namespace Indian_State_Censun_Analyser
{
    //custom exception
    public class CensusAnalyserException : Exception
    {
        //range of constant
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, NO_SUCH_COUNTRY, INCORRECT_HEADER
        }
        public ExceptionType etype;
        public CensusAnalyserException(string message, ExceptionType etype) : base(message)
        {
            this.etype = etype;
        }
    }
}
