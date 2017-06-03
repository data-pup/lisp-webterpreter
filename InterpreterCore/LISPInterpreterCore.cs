using System;
using System.Collections.Generic;

using InterpreterCore.InputParsing;

namespace InterpreterCore
{
    public class LISPInterpreterCore
    {
        public Dictionary<string,Object> variables { get; }
        public LISPInterpreterCore()
        {
            variables = new Dictionary<string,Object>();
        }

        public string[] ParseInputLine(string inputLine)
        {
            return RawInputParser.ParseExpressionIntoList(inputLine);
        }

        /// <summary>
        /// Pass an array the the client, for debugging purposes.
        /// </summary>
        public string[] Greet()
        {
            return new string[] {"hello", "world"};
        }
    }
}
