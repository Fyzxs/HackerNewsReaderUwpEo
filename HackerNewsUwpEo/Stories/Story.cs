using HackerNewsUwpEo.Mixins;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories
{
    public interface Story
    {
        Task TitleInto(SetText item);
        Task AuthorInto(SetText item);
    }
}