using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class LISPInterpreterCore
    {
        public Dictionary<string,Object> variables { get; }
        public LISPInterpreterCore()
        {
            variables = new Dictionary<string,Object>();
        }

        /// <summary>
        /// Pass an array the the client, for debugging purposes.
        /// </summary>
        public List<String> Greet()
        {
            return new List<String>(){"hello", "world"};
        }
    }
}
