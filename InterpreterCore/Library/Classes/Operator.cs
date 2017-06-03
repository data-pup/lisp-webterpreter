using System;
using System.Collections.Generic;
using InterpreterCore.Classes;

namespace InterpreterCore.Operators
{
    public class LISPOperator<T>
    {
        private string _token { get; }
        public LISPOperator(string token)
        {
            _token = token;
        }
    }
}