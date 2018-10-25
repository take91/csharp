using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



namespace HelloWorld_2
{
    class MyMain
    {

        [STAThread]
        public static void Main()
        {
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            Application app = new Application();
            app.ShutdownMode = ShutdownMode.OnLastWindowClose;  
            
            for(int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window NO. " + (i + 1);
                //win.ShowInTaskbar = false;
                win.Show();
            }
            app.Run(mainWindow);
        }

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    Window mainWindow = new Window();
        //    mainWindow.Title = "WPF Sample(Main)";
        //    mainWindow.MouseDown += WinMouseDown;
        //    mainWindow.Show();

        //    for (int i = 0; i < 2; i++)
        //    {
        //        Window win = new Window();
        //        win.Title = "Extra Window NO. " + (i + 1);
        //        win.Show();
        //    }

        //}


       static void WinMouseDown(object sender, MouseEventArgs e)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;

            win.Content = b;
            win.ShowDialog();

        }


        static void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
