using System;

namespace HackerNewsUwpEo.CactooSharp.Scalars
{
    public class NotNull<T> : Scalar<T> where T : class
    {
        private readonly Scalar<T> _origin;

        public NotNull(T origin) : this(new ValueItem<T>(origin))
        {
        }
        public NotNull(Scalar<T> origin) => _origin = origin;


        public T Value()
        {
            if (_origin == null) throw new Exception("NULL instead of valid scalar");
            if (_origin.Value() == null) throw new Exception("NULL instead of valid value");

            return _origin.Value();
        }
    }
}
