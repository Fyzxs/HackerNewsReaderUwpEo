using HackerNewsUwpEo.CactooSharp;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public interface Client
    {
        Task<Text> Text();
    }
}