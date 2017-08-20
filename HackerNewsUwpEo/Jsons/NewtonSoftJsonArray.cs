using HackerNewsUwpEo.CactooSharp;

namespace HackerNewsUwpEo.Jsons {
    public class NewtonSoftJsonArray : JsonArray
    {
        private readonly Text _text;

        public NewtonSoftJsonArray(Text text) => _text = text;
    }
}