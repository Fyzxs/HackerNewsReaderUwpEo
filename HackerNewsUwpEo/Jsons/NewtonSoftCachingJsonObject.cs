using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using Newtonsoft.Json.Linq;
using System.IO;

namespace HackerNewsUwpEo.Jsons
{
    public class NewtonSoftCachingJsonObject : JsonObject
    {
        private readonly Text _origin;
        private JObject _parsed;

        public NewtonSoftCachingJsonObject(Stream origin) : this(new TextOf(origin)) { }
        public NewtonSoftCachingJsonObject(string origin) : this(new TextOf(origin)) { }

        public NewtonSoftCachingJsonObject(Text origin) => _origin = origin;

        public T Value<T>(string key) => Parsed().Value<T>(key);

        private JObject Parsed() => _parsed ?? (_parsed = JObject.Parse(_origin.String()));
    }
}