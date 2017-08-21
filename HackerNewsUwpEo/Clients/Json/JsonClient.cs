using System.Threading.Tasks;
using HackerNewsUwpEo.Jsons;

namespace HackerNewsUwpEo.Clients.Json {
    public interface JsonClient
    {
        Task<JsonArray> JsonArray();
        Task<JsonObject> JsonObject();
    }
}