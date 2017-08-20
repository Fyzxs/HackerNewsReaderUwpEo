using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories.Top
{
    public class ClientCacheTopStories : TopStories
    {
        private readonly Client _client;
        private JsonArray _jsonArray;

        public ClientCacheTopStories() : this(new GetClient("https://hacker-news.firebaseio.com/v0/topstories.json")) { }
        public ClientCacheTopStories(Client client) => _client = client;
        public async Task<string> NextId() => (await JsonArray()).Next<string>();
        public async Task<int> Count() => (await JsonArray()).Count();

        private async Task<JsonArray> JsonArray() => _jsonArray ?? (_jsonArray = await _client.JsonArray());
    }
}