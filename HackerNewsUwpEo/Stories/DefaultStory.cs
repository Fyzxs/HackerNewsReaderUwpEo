using HackerNewsUwpEo.Mixins;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories
{
    public class DefaultStory : Story
    {
        private readonly Story _origin;

        public DefaultStory(string id) : this(new ClientStory(id)) { }
        public DefaultStory(Story origin) => _origin = origin;

        public async Task TitleInto(SetText item) => await _origin.TitleInto(item);

        public async Task AuthorInto(SetText item) => await _origin.AuthorInto(item);
    }
}