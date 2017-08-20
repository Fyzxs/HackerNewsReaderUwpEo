using HackerNewsUwpEo.Mixins;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace HackerNewsUwpEo.Widgets
{
    public class TextWidget : SetText
    {
        private readonly TextBox _textBox;

        public TextWidget(TextBox textBox) => _textBox = textBox;

        public string Text
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            set => CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => _textBox.Text = value);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

        }
    }
}
