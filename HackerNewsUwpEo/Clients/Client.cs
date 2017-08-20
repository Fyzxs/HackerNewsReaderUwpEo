using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.Jsons;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public interface Client
    {
        Task<JsonParser> JsonParser();
        Task<Text> Text();
    }
}