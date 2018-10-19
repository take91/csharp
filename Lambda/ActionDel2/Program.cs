using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ActionDel2
{
    public delegate void ShowName();

    public class Onj
    {
        private string name;

        public Onj(string name) { this.name = name; }
        public void DisplayToConsole() { Console.WriteLine(this.name); }
        public void DisplayToWindow() { MessageBox.Show(this.name); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Onj onj1 = new Onj("실무개발자닷넷교육");
            ShowName act1 = onj1.DisplayToWindow;
            act1();


            Onj onj2 = new Onj("오라클자바커뮤니티");
            Action act2 = onj2.DisplayToWindow;
            act2();


            Onj onj3 = new Onj("오라클자바커뮤니티교육센터");
            Action act3 = delegate ()
            {
                onj3.DisplayToWindow();
            };
            act3();


            Onj onj4 = new Onj("oraclejavacommunity");
            Action act5 = () => onj4.DisplayToWindow();
            act5();
            




        }
    }
}
