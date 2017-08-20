using HackerNewsUwpEo.Mixins;
using HackerNewsUwpEo.Stories;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{
    public class FakeStory : Story
    {
        private string _title;
        private string _author;

        public FakeStory() { }

        public FakeStory Title(string title)
        {
            _title = title;
            return this;
        }

        public FakeStory Author(string author)
        {
            _author = author;
            return this;
        }

        public Task TitleInto(SetText item) => Task.Run(() => item.Text = _title);

        public Task AuthorInto(SetText item) => Task.Run(() => item.Text = _author);
    }
}