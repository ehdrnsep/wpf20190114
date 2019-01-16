using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StyleTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public class DataObject
        {
            public string Name { get; set; }
            public int TheValue { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataObject();

            List<DataObject> foos = new List<DataObject>();
            foos.Add(new DataObject() { Name = "Test", TheValue = 1 });
            foos.Add(new DataObject() { Name = "Test2", TheValue = 2 });
            foos.Add(new DataObject() { Name = "Test3", TheValue = 3 });
            foos.Add(new DataObject() { Name = "Test4", TheValue = 6 });
            foos.Add(new DataObject() { Name = "Test5", TheValue = 1 });

            int[] datas = foos.Select(a => a.TheValue).OrderBy(a => a).ToArray();
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            MessageBox.Show(btn.Content + " has been clicked", Title);
        }
    }
}
