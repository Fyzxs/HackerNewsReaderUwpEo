using HackerNewsUwpEo.CactooSharp;
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

        public Task<JsonArray> JsonArray(Text text) => Task.FromResult(_jsonArray);

        public Task<JsonObject> JsonObject(Text text) => Task.FromResult(_jsonObject);
    }
}