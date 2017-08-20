using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public interface Client
    {
        Task<JsonArray> JsonArray();
        Task<JsonObject> JsonObject();
        Task<Text> Text();
    }
}