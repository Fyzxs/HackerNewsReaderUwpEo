using HackerNewsUwpEo.CactooSharp;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Jsons
{
    public interface JsonParser
    {
        Task<JsonArray> JsonArray(Text text);
        Task<JsonObject> JsonObject(Text text);
    }
}