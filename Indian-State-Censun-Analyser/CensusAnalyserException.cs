using System;
using System.Collections.Generic;
using System.Text;

namespace Indian_State_Censun_Analyser
{
    public class CensusAnalyserException : Exception
    {
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
