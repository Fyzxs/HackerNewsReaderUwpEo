using HackerNewsUwpEo.CactooSharp;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Jsons
{
    public class NewtonSoftJsonParser : JsonParser
    {
        public Task<JsonArray> JsonArray(Text text) => Task.Run(() => new NewtonSoftJsonArray(text) as JsonArray);

        public Task<JsonObject> JsonObject(Text text) => Task.Run(() => new NewtonSoftJsonObject(text) as JsonObject);
    }
}