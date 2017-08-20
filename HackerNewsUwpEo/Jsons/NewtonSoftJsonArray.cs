using HackerNewsUwpEo.CactooSharp;
using Newtonsoft.Json.Linq;

namespace HackerNewsUwpEo.Jsons
{
    public class NewtonSoftJsonArray : JsonArray
    {
        private readonly Text _text;
        private JArray _jArray;
        private int _indexer;

        public NewtonSoftJsonArray(Text text) => _text = text;

        public T Next<T>() => Parse()[_indexer++].Value<T>();

        public int Count() => Parse().Count;

        private JArray Parse() => _jArray ?? (_jArray = JArray.Parse(_text.String()));

    }
}