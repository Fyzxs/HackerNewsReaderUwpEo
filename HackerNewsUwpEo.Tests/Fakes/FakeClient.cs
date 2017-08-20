using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeClient : Client
    {
        private readonly Text _text;
        private readonly JsonParser _json;
        public FakeClient(JsonParser json) => _json = json;
        public FakeClient(Text text) => _text = text;

        public Task<JsonParser> JsonParser() => Task.FromResult(_json);

        public Task<Text> Text() => Task.FromResult(_text);
    }
}