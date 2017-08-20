using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories.Top
{
    public class DefaultTopStories : TopStories
    {
        private readonly TopStories _origin;

        public DefaultTopStories() : this(new ClientCacheTopStories()) { }
        public DefaultTopStories(TopStories origin) => _origin = origin;

        public Task<string> NextId() => _origin.NextId();
        public Task<int> Count() => _origin.Count();
    }
}