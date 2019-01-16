using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LoadXaml
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoadXaml : Window
    {
        [STAThread]
        public static void Main()
        {
            //Application app = new Application();
            //app.Run(new LoadXaml());

            Application app = new Application();
            // Pack Uri 체계를 통한 리소스 파일을 식별하여 로딩
            // 로컬 어셈블리의 프로젝트 폴더 루트에 있는 리소스 파일에 대한 Pack URI
            Uri uri = new Uri("pack://application:,,,/XamlWindow.xml");
            Stream stream = Application.GetResourceStream(uri).Stream;
            Window win = XamlReader.Load(stream) as Window;
            win.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click1));
            Button b = (Button)win.FindName("XamlButton"); // XAML파일에 정의
            b.Click += Button_Click2;
            app.Run(win);
        }

        public LoadXaml()
        {
            this.Title = "Load Embedded Xaml";


            //string strXaml =
            //   "<Button xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'" +
            //   " Foreground='LightSeaGreen' FontSize='26pt'>" +
            //   " Hello, WPF!" +
            //   "</Button>";

            //StringReader strReader = new StringReader(strXaml);
            //XmlTextReader xmlReader = new XmlTextReader(strReader);
            //Button b = (Button)XamlReader.Load(xmlReader);
            //b.Click += B_Click;

            //Content = b;
        }

        static void Button_Click1(object sender, RoutedEventArgs args)
        {
            MessageBox.Show((args.Source as Button).Content.ToString() + "1");
        }
        static void Button_Click2(object sender, RoutedEventArgs args)
        {
            MessageBox.Show(((Button)sender).Content.ToString() + "2");
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Embedded Xaml Test");
        }
    }
}
