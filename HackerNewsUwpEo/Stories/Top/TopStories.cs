using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories.Top
{
    public interface TopStories
    {
        Task<string> NextId();
        Task<int> Count();
    }
}