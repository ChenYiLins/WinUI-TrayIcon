using Microsoft.UI.Xaml;

namespace WinUITrayIcon
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(0, 0, 400, 200));
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
