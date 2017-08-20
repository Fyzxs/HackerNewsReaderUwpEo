using HackerNewsUwpEo.Stories.Top;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HackerNewsUwpEo.Widgets
{
    public sealed partial class StoryList : UserControl
    {
        public StoryList()
        {
            this.InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TopStories topStories = new DefaultTopStories();
            int count = await topStories.Count();
            for (int i = 0; i < count; i++)
            {
                ListViewStories.Items.Add(new StoryWidget(await topStories.NextId()));
            }

        }
    }
}
