using HackerNewsUwpEo.Stories;
using System;
using Windows.ApplicationModel;

namespace HackerNewsUwpEo.Widgets
{
    public sealed partial class StoryWidget
    {
        private readonly string _id;
        public StoryWidget() : this(null)
        {
            if (!DesignMode.DesignModeEnabled) throw new Exception("Invalid Ctor");
        }

        public StoryWidget(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void Grid_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (DesignMode.DesignModeEnabled) return;

            Story story = new DefaultStory(_id);
            await story.AuthorInto(new TextWidget(TxtAuthor));
            await story.TitleInto(new TextWidget(TxtTitle));
        }
    }
}
