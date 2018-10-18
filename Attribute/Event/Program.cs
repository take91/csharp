using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class EventPublisher
    {

        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        {
            //if (MyEvent != null)
            //{
            //    MyEvent();
            //}
            MyEvent?.Invoke(null,null);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += doAction;
            p.Do();

        }

        static void doAction(Object sender, EventArgs e)
        {
            Console.WriteLine("My Event라는 이벤트 발생..");
        }
    }
}
