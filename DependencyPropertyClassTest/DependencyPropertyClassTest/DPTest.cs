using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyPropertyClassTest
{
    public class DPTest : DependencyObject
    {
        public string Test
        {
            get { return (string)GetValue(TestProperty); }
            set { SetValue(TestProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Test.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestProperty =
            DependencyProperty.Register("Test", typeof(string), typeof(DPTest), new PropertyMetadata("초기값", OnTestPropertyChanged));

        static void OnTestPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine($"Property Changed : {e.NewValue}");
        }

    }
}
