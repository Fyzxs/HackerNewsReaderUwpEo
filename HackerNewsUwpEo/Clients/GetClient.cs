using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using HackerNewsUwpEo.Jsons;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public class GetClient : Client
    {
        private readonly string _url;
        private readonly HttpClient _client;
        private readonly JsonParser _jsonParser;

        public GetClient(string url) : this(url, new HttpClient(), new NewtonSoftJsonParser()) { }

        public GetClient(string url, HttpClient client, JsonParser jsonParser)
        {
            _url = url;
            _client = client;
            _jsonParser = jsonParser;
        }
        public async Task<JsonArray> JsonArray() => await _jsonParser.JsonArray(await Text());

        public async Task<JsonObject> JsonObject() => await _jsonParser.JsonObject(await Text());

        public async Task<Text> Text() => new TextOf(await _client.GetStringAsync(_url));
    }
}