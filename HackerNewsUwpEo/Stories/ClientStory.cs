using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Mixins;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories
{
    public class ClientStory : Story
    {
        private const string UrlFormat = "https://hacker-news.firebaseio.com/v0/item/{0}.json";
        private readonly Client _client;
        private Story _origin;
        private async Task<Story> Origin() => _origin ?? (_origin = new JsonStory(await _client.Json()));

        public ClientStory(string id) : this(new GetClient($"https://hacker-news.firebaseio.com/v0/item/{id}.json")) { }
        public ClientStory(Client client) => _client = client;

        public async Task TitleInto(SetText item) => await (await Origin()).TitleInto(item);

        public async Task AuthorInto(SetText item) => await (await Origin()).AuthorInto(item);
    }
}