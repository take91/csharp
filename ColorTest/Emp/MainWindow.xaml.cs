using System;
using System.Windows;

namespace Emp
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Emp_s x = Grid1.DataContext as Emp_s;
            Console.WriteLine(x.Ename);
            Console.WriteLine(x.City);
        }
    }
}
