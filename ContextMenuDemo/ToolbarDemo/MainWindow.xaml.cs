using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ToolbarDemo
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<String> list = new List<string>();
            InitializeComponent();
            list.Add("서울");
            list.Add("대전");
            list.Add("대구");
            list.Add("부산");

            toolbar.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).Content.ToString());
        }
    }
}
