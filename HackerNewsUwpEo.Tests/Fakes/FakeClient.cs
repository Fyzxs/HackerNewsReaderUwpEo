using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeClient : Client
    {
        private readonly JsonObject _jsonObject;
        private readonly JsonArray _jsonArray;
        private readonly Text _text;

        public FakeClient(JsonArray jsonArray) => _jsonArray = jsonArray;

        public FakeClient(JsonObject jsonObject) => _jsonObject = jsonObject;
        public FakeClient(Text text) => _text = text;

        public Task<JsonArray> JsonArray() => Task.Run(() => _jsonArray);

        public Task<JsonObject> JsonObject() => Task.Run(() => _jsonObject);

        public Task<Text> Text() => Task.FromResult(_text);
    }
}