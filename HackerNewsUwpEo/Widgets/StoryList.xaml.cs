using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace HackerNewsUwpEo.Widgets
{
    public sealed partial class StoryList : UserControl
    {
        public StoryList()
        {
            this.InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (int item in new List<int>() { 15056751, 15054252, 15056472, 15055480, 15055522, 15054105 })
            {
                ListViewStories.Items.Add(new StoryWidget(item.ToString()));
            }

        }
    }
}
