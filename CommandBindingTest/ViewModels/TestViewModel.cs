
using CommandBindingTest.Views;
using ReactiveUI;
using System.Reactive;

namespace CommandBindingTest.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public TestViewModel()
        {
            CloseWindow = ReactiveCommand.Create(closeWindow);
        }
        
        void closeWindow()
        {
            var aboutWindow = App.WindowDict["AboutWindow"];
            aboutWindow.Close();
        }
        public ReactiveCommand<Unit, Unit> CloseWindow { get; set; }
    }
}
