using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    //delegate void MyDelegate(int i);
    class EventPublisher
    {
        public event EventHandler ClapEvent;
        public void Clap(int num)
        {
            if (num % 2 == 0 && ClapEvent != null) ClapEvent.Invoke(num, null);

        }

        public class EventSub
        {

            static void Caller(object sender, EventArgs e)
            {
                Console.WriteLine("{0} : 짝~", e);
            }



            static void Main(string[] args)
            {
                EventPublisher p = new EventPublisher();
                p.ClapEvent += (sender, e) => { Console.WriteLine("{0} : 짝~", sender); };
                Console.WriteLine("숫자를 입력해주세요.");
                int[] iArr = Array.ConvertAll((Console.ReadLine()).Split(','), i => int.Parse(i));

                foreach (int i in iArr)
                {
                    p.Clap(i);
                }
            }
        }
    }
}



