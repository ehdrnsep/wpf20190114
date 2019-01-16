using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HelloWord2
{
    public class MyMain : Application
    {
        [STAThread]
        public static void Main()
        {
            MyMain app = new MyMain();
            app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample (Window)";
            mainWindow.MouseDown += MainWindow_MouseDown;
            mainWindow.Show();

            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.ShowInTaskbar = false;
                win.Owner = mainWindow;
                win.Show();
            }
        }

        private void MainWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += B_Click;

            win.Content = b;
            win.ShowDialog();
        }

        private void B_Click
            (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
