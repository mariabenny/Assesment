using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Animal
    {
        String name;
        int max_lifetime;
        String food;
        public Animal()
        {
            name = "Cat";
            max_lifetime = 18;
            food = "milk";
        }
        public void set()
        {
            Console.WriteLine("Animal");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Max lifetime:" + max_lifetime);
            Console.WriteLine("Food:" + food);
        }
    }
}
