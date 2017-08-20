namespace HackerNewsUwpEo.CactooSharp.Scalars
{
    public class ValueItem<T> : Scalar<T>
    {
        private readonly T _origin;

        public ValueItem(T origin) => _origin = origin;

        public T Value() => _origin;
    }
}