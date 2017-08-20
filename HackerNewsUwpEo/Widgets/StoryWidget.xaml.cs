using HackerNewsUwpEo.Stories;
using Windows.ApplicationModel;

namespace HackerNewsUwpEo.Widgets
{
    public sealed partial class StoryWidget
    {
        public StoryWidget()
        {
            InitializeComponent();
        }

        private async void Grid_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (DesignMode.DesignModeEnabled) return;

            Story story = new ClientStory("8863");
            await story.AuthorInto(new TextWidget(TxtAuthor));
            await story.TitleInto(new TextWidget(TxtTitle));
        }
    }
}
