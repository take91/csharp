using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 13. 실행결과는? (먼저 예측하고 코딩해보세요.)


namespace Test13
{
    class Dog

    {

        public string Name { get; set; }

        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() {

            new Dog { Name = "Rex", Age = 4 },

            new Dog { Name = "Sean", Age = 0 },

            new Dog { Name = "Stacy", Age = 3 }

         };

            var names = dogs.Select(x => x.Name);

            foreach (var name in names)

            {

                Console.WriteLine(name);



            }

            Console.Read();
        }
    }
}
