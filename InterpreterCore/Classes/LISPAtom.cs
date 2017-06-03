namespace InterpreterCore.Classes
{
    public class LISPAtom<T>
    {
        private T _value;
        public LISPAtom(T value)
        {
            _value = value;
        }
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}