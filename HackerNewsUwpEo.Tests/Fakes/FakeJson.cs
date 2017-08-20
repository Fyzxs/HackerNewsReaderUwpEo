using HackerNewsUwpEo.Jsons;
using System.Collections.Generic;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeJson : Json
    {
        private readonly Dictionary<string, object> _dictionary;

        public FakeJson(Dictionary<string, object> dictionary) => _dictionary = dictionary;

        public T Value<T>(string key) => (T)_dictionary[key];
    }
}