using System;

namespace InterpreterCore.Classes.Lisp
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

        public static LISPAtom<T> operator +(LISPAtom<T> lhs, LISPAtom<T> rhs)
        {
            if(lhs == null || rhs == null)
                throw new NotImplementedException("'+' operator given null argument.");
            T leftValue = lhs.Value;
            T rightValue = rhs.Value;
            T result = Sum(leftValue, rightValue);
            return new LISPAtom<T>(result);
        }
        public static LISPAtom<T> operator -(LISPAtom<T> lhs, LISPAtom<T> rhs)
        {
            if(lhs == null || rhs == null)
                throw new NotImplementedException("'+' operator given null argument.");
            T leftValue = lhs.Value;
            T rightValue = rhs.Value;
            T result = Difference(leftValue, rightValue);
            return new LISPAtom<T>(result);
        }
        public static LISPAtom<T> operator *(LISPAtom<T> lhs, LISPAtom<T> rhs)
        {
            if(lhs == null || rhs == null)
                throw new NotImplementedException("'+' operator given null argument.");
            T leftValue = lhs.Value;
            T rightValue = rhs.Value;
            T result = Product(leftValue, rightValue);
            return new LISPAtom<T>(result);
        }
        public static LISPAtom<T> operator /(LISPAtom<T> lhs, LISPAtom<T> rhs)
        {
            if(lhs == null || rhs == null)
                throw new NotImplementedException("'+' operator given null argument.");
            T leftValue = lhs.Value;
            T rightValue = rhs.Value;
            T result = Quotient(leftValue, rightValue);
            return new LISPAtom<T>(result);
        }

        private static T Sum(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        private static T Difference(T left, T right)
        {
            return (dynamic)left - (dynamic)right;
        }
        private static T Product(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
        private static T Quotient(T num, T denom)
        {
            return (dynamic)num / (dynamic)denom;
        }
    }
}