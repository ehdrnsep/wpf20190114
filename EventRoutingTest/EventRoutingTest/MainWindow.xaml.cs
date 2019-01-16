using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventRoutingTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Preview Window Mouse Down!");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Preview StaqkPanel Mouse Down!");
        }

        private void txt1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Preview TextBox Mouse Down!");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Window Mouse Down!");
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("StaqkPanel Mouse Down!");
        }

        private void txt1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("TextBox Mouse Down!");
        }
    }
}
