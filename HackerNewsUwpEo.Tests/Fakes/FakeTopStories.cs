using HackerNewsUwpEo.Stories.Top;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeTopStories : TopStories
    {
        private readonly List<string> _stories;
        private int _index;

        public FakeTopStories(List<string> stories) => _stories = stories;
        public Task<string> NextId() => Task.Run(() => _stories[_index++]);

        public Task<int> Count() => Task.Run(() => _stories.Count);
    }
}