using System;
using System.Collections.Generic;
using InterpreterCore.Classes;
using InterpreterCore.Operators.Math;

namespace InterpreterCore.Operators
{
    public class LISPOperator<T>
    {
        private string _token;
        private Func<IEnumerable<LISPAtom<T>>,LISPAtom<T>> _function;
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