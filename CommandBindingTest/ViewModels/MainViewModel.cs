using CommandBindingTest.Views;
using ReactiveUI;
using System.Reactive;

namespace CommandBindingTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public MainViewModel()
    {
        TestCommand = ReactiveCommand.Create(testCommand);
    }

    void testCommand()
    {
        var mainWindow = App.WindowDict["MainWindow"];
        var testWindow = new TestWindow();
        testWindow.ShowDialog(mainWindow);
    }
    public ReactiveCommand<Unit, Unit> TestCommand { get; private set; }
}
