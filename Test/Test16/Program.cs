using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16. 실행결과를 확인하고 코드를 완성하세요.

//[실행결과]
//Dog
//Cat
//Mouse
//Mouse




namespace Test16
{
    public delegate void EventHandler();
    class Program
    {
        public static event EventHandler _show;
        static void Main(string[] args) {

            _show = (EventHandler)Delegate.Combine(
               new EventHandler(Dog),
               new EventHandler(Cat),
               new EventHandler(Mouse),
               new EventHandler(Mouse)
                );

            // Invoke the event. 
            _show.Invoke();
        }
        static void Cat()
        {
            Console.WriteLine("Cat");
        }

        static void Dog()
        {
            Console.WriteLine("Dog");
        }

        static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
    }
}
