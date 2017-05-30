using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class LISPInterpreterCore
    {
        public LISPInterpreterCore()
        {
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
