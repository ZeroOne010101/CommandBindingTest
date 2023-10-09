using Avalonia.Controls;

namespace CommandBindingTest.Views
{
    public partial class TestWindow : Window
    {
        private static readonly string windowIdentifier = "TestWindow";

        public TestWindow()
        {
            InitializeComponent();
            App.WindowDict.Add(windowIdentifier, this);
        }

        ~TestWindow()
        {
            App.WindowDict.Remove(windowIdentifier);
        }
    }
}
