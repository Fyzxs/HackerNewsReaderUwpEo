using HackerNewsUwpEo.CactooSharp;

namespace HackerNewsUwpEo.Jsons
{
    public class NewtonSoftJsonObject : JsonObject
    {
        private readonly JsonObject _jsonObject;

        public NewtonSoftJsonObject(Text text) : this(new DefaultJson(text)) { }

        public NewtonSoftJsonObject(JsonObject jsonObject) => _jsonObject = jsonObject;

        public T Value<T>(string key) => _jsonObject.Value<T>(key);
    }
}