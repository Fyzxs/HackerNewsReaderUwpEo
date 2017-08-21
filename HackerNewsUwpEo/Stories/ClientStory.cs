using HackerNewsUwpEo.Clients.Json;
using HackerNewsUwpEo.Mixins;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories
{
    public class ClientStory : Story
    {
        private readonly JsonClient _jsonClient;
        private Story _origin;
        private async Task<Story> Origin() => _origin ?? (_origin = new JsonStory(await _jsonClient.JsonObject()));

        public ClientStory(string id) : this(new DefaultJsonClient($"https://hacker-news.firebaseio.com/v0/item/{id}.json")) { }
        public ClientStory(JsonClient jsonClient) => _jsonClient = jsonClient;
        public async Task TitleInto(SetText item) => await (await Origin()).TitleInto(item);

        public async Task AuthorInto(SetText item) => await (await Origin()).AuthorInto(item);
    }
}