using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace Avi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            SetGlobalExceptionHandler();
        }

        private void SetGlobalExceptionHandler() => AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

        private void CurrentDomain_FirstChanceException(object? sender, FirstChanceExceptionEventArgs e)
        {
            Debug.WriteLine($"***** Handling Unhandled Exception *****: {e.Exception.Message}");
#if DEBUG
            //toast here
#endif
        }
    }
}
