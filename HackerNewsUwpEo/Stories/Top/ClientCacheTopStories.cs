using HackerNewsUwpEo.Clients.Json;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories.Top
{
    public class ClientCacheTopStories : TopStories
    {
        private readonly JsonClient _jsonClient;
        private JsonArray _jsonArray;

        public ClientCacheTopStories() : this(new DefaultJsonClient("https://hacker-news.firebaseio.com/v0/topstories.json")) { }
        public ClientCacheTopStories(JsonClient jsonClient) => _jsonClient = jsonClient;
        public async Task<string> NextId() => (await JsonArray()).Next<string>();
        public async Task<int> Count() => (await JsonArray()).Count();

        private async Task<JsonArray> JsonArray() => _jsonArray ?? (_jsonArray = await _jsonClient.JsonArray());
    }
}