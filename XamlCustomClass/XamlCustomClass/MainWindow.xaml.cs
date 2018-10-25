﻿using SelectColorFromGrid;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace XamlCustomClass
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



        private void ColorGridBoxOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ColorGridBox clrbox = e.Source as ColorGridBox;
            Background = (Brush)clrbox.SelectedValue;
        }
    }
}
