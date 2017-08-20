using System.Threading.Tasks;
using HackerNewsUwpEo.CactooSharp;

namespace HackerNewsUwpEo.Jsons {
    public class NewtonSoftJsonParser : JsonParser
    {
        private readonly Text _text;

        public NewtonSoftJsonParser(Text text) => _text = text;

        public async Task<JsonArray> AsJsonArray() => await Task.Run(() => new NewtonSoftJsonArray(_text));

        public async Task<JsonObject> AsJsonObject() => await Task.Run(() => new NewtonSoftJsonObject(_text));
    }
}