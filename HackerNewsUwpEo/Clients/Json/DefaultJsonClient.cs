using System.Threading.Tasks;
using HackerNewsUwpEo.Jsons;

namespace HackerNewsUwpEo.Clients.Json {
    public class DefaultJsonClient : JsonClient
    {
        private readonly Client _origin;
        private readonly JsonParser _jsonParser;

        public DefaultJsonClient(string url) : this(new CacheClient(url), new NewtonSoftJsonParser()) { }
        public DefaultJsonClient(Client origin, JsonParser jsonParser)
        {
            _origin = origin;
            _jsonParser = jsonParser;
        }

        public async Task<JsonArray> JsonArray() => await _jsonParser.JsonArray(await _origin.Text());

        public async Task<JsonObject> JsonObject() => await _jsonParser.JsonObject(await _origin.Text());
    }
}