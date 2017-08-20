using HackerNewsUwpEo.Jsons;
using HackerNewsUwpEo.Mixins;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Stories
{
    public class JsonStory : Story
    {
        private readonly Json _origin;
        public JsonStory(Json origin) => _origin = origin;

        public async Task TitleInto(SetText item) => await Task.Run(() => item.Text = _origin.Value<string>("title"));

        public async Task AuthorInto(SetText item) => await Task.Run(() => item.Text = _origin.Value<string>("by"));
    }
}