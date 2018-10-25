﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace RoutedEventDemo
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

        private void txtBlk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(null);
            string MousePosText = string.Format("X = {0}, Y = {1}", p.X, p.Y);


            if (e.LeftButton == MouseButtonState.Pressed) MessageBox.Show("왼쪽 " + MousePosText);
            else if (e.RightButton == MouseButtonState.Pressed) MessageBox.Show("오른쪽 " + MousePosText);
            else if (e.MiddleButton == MouseButtonState.Pressed) MessageBox.Show("가운데 " + MousePosText);
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string str = (e.Source as MenuItem).Header as string;
            Color color = (Color)ColorConverter.ConvertFromString(str);
            txtBlk.Foreground = new SolidColorBrush(color);
        }
    }
}
