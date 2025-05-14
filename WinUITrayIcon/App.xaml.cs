using Microsoft.UI.Xaml;
using WinUITrayIcon.Taskbar;

namespace WinUITrayIcon
{
    public partial class App : Application
    {
        private Window? _window;
        private SystemTrayIcon? _trayIcon;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();
            _window.Activate();

            _trayIcon = new SystemTrayIcon();
            _trayIcon.Show();
        }
    }
}
