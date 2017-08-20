using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using Newtonsoft.Json.Linq;
using System.IO;

namespace HackerNewsUwpEo.Jsons
{
    public class DefaultJson : Json
    {
        private readonly Text _origin;
        private JObject _parsed;

        public DefaultJson(Stream origin) : this(new TextOf(origin)) { }
        public DefaultJson(string origin) : this(new TextOf(origin)) { }

        public DefaultJson(Text origin) => _origin = origin;


        public T Value<T>(string key) => Parsed().Value<T>(key);

        private JObject Parsed() => _parsed ?? (_parsed = JObject.Parse(_origin.String()));
    }
}