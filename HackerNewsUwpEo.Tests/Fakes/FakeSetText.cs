using HackerNewsUwpEo.Mixins;
using System;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeSetText : SetText
    {
        public string Text { private get; set; }

        public void Assert(Action<string> assert)
        {
            assert(Text);
        }
    }
}