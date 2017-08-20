using HackerNewsUwpEo.CactooSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeText : Text
    {
        private int _index;
        private readonly List<Func<string>> _funcs;

        public FakeText(string origin) : this(new List<Func<string>> { () => origin }) { }

        public FakeText(List<Func<string>> funcs) => _funcs = funcs;

        public FakeText(params Func<string>[] funcs) : this(funcs.ToList()) { }

        public string String() => _index >= _funcs.Count
            ? _funcs.Last()()
            : _funcs[_index++]();
    }
}