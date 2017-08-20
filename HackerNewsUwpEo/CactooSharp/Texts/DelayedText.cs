using System;

namespace HackerNewsUwpEo.CactooSharp.Texts
{
    public class DelayedText : Text
    {
        private readonly Func<string> _func;

        public DelayedText(Func<string> func) => _func = func;

        public string String() => _func.Invoke();
    }
}