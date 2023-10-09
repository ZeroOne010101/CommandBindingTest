using Avalonia.Controls;

namespace CommandBindingTest.Views;

public partial class MainWindow : Window
{
    private static readonly string windowIdentifier = "MainWindow";

    public MainWindow()
    {
        InitializeComponent();
        App.WindowDict.Add(windowIdentifier, this);
    }
}
