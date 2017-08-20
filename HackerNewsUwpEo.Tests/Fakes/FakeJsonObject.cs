using HackerNewsUwpEo.Jsons;
using System.Collections.Generic;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeJsonObject : JsonObject
    {
        private readonly Dictionary<string, object> _dictionary;

        public FakeJsonObject(Dictionary<string, object> dictionary) => _dictionary = dictionary;

        public T Value<T>(string key) => (T)_dictionary[key];
    }
}