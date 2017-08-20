using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeJsonParser : JsonParser
    {
        private readonly JsonObject _jsonObject;
        private readonly JsonArray _jsonArray;

        public FakeJsonParser(JsonObject jsonObject) => _jsonObject = jsonObject;
        public FakeJsonParser(JsonArray jsonArray) => _jsonArray = jsonArray;

        public Task<JsonArray> AsJsonArray() => Task.FromResult(_jsonArray);

        public Task<JsonObject> AsJsonObject() => Task.FromResult(_jsonObject);
    }
}