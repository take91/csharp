using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate string FirstDelegate(int x);
    class DelegateTest
    {
        string name;
        static void Main(string[] args)
        {
            FirstDelegate d1 = new FirstDelegate(StaticMethod);



            DelegateTest instance = new DelegateTest();

            instance.name = "My instance";

            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);



            Console.WriteLine(d1(10)); // Writes out "Static method: 10"

            Console.WriteLine(d2(5));  // Writes out "My instance: 5"
        }
        static string StaticMethod(int i)

        {

            return string.Format("Static method: {0}", i);

        }



        string InstanceMethod(int i)

        {

            return string.Format("{0}: {1}", name, i);

        }
    }
}
