using System.Windows;
namespace BindingTest3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //CarDependency" 라는 리소스 검색
            CarDependencyProperty dpSample = TryFindResource("CarDependency") as CarDependencyProperty;
            MessageBox.Show(dpSample.MyCar);
        }
    }

    public class CarDependencyProperty : DependencyObject
    {
        //Register Dependency Property  
        public static readonly DependencyProperty CarDependency = DependencyProperty.Register("MyProperty", typeof(string), typeof(CarDependencyProperty));
        public string MyCar
        {
            get
            {
                return (string)GetValue(CarDependency);
            }
            set
            {
                SetValue(CarDependency, value);
            }
        }
    }
}