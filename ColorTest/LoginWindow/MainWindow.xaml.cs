using System.ComponentModel;
using System.Windows;

namespace LoginWindow
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(VMMainWindow.LastName + ":" + VMMainWindow.FirstName);
        }
    }
}
