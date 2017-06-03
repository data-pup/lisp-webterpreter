using System;
using System.Collections.Generic;
using InterpreterCore.Classes;

namespace InterpreterCore.Operators
{
    public class LISPOperator<T>
    {
        private string _token;
        private T _value;
        public LISPOperator(string token, T value)
        {
            _token = token;
            _value = value;
        }
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}