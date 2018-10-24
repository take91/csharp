using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MouseEvent
{
    class Program : Form
    {
        public void MouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Sender : "+((Form)sender).Text);
            Console.WriteLine("Sender : "+((Form)sender).Name);
            Console.WriteLine("X:{0}, Y:{1}",e.X, e.Y);
            Console.WriteLine("Button:{0}, Clicks{1}",e.Button, e.Clicks);
        }

        public Program(string title)
        {
            this.Text = title;
            this.Name = "윈폼";

            this.MouseDown += new MouseEventHandler(MouseHandler);

        }

        static void Main(string[] args)
        {
            Application.Run(new Program("마우스 이벤트 예제"));
        }
    }
}
