using System.Threading.Tasks;

namespace HackerNewsUwpEo.Jsons {
    public interface JsonParser
    {
        Task<JsonArray> AsJsonArray();
        Task<JsonObject> AsJsonObject();
    }
}