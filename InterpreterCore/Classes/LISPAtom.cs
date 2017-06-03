namespace InterpreterCore.Classes
{
    public class LISPAtom<T>
    {
        public T Value { get; set; }
        public LISPAtom(T _Value)
        {
            Value = _Value;
        }
    }
}