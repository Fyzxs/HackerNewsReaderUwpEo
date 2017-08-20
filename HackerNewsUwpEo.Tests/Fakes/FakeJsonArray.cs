using HackerNewsUwpEo.Jsons;
using Newtonsoft.Json.Linq;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeJsonArray : JsonArray
    {
        private readonly JArray _jArray;
        private int _indexer;

        public FakeJsonArray(JArray jArray) => _jArray = jArray;
        public T Next<T>() => _jArray[_indexer++].Value<T>();

        public int Count() => _jArray.Count;
    }
}
