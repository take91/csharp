using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    class OnjMessageFilter : IMessageFilter
    {
        int count = 1;
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201 && count <= 5)
            {
                Console.WriteLine("마우스 클릭 필터링 됨...({0})", count);
                count++;
                return true;
            }
            return false;

        }
    }


    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program form = new Program();
            form.Click += new EventHandler((sender, e) =>
            {
                Console.WriteLine("폼클릭 이벤트");
                Application.Exit();
            });
            Console.WriteLine("윈도우 시작...");
            Application.Run(form);
            Console.WriteLine("윈도우 종료...");

        }


    }
}
