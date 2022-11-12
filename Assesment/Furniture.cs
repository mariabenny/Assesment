using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Furniture
    {
        String type;
        String wood;
        int price;

        public Furniture()
        {
            type = "chair";
            wood = "teak";
            price = 2000;
            Console.WriteLine("Constructor without parameter");
            Display();
        }
        public Furniture(string Wood)
        {
            type = "table";
            wood = Wood;
            price = 30000;
            Console.WriteLine("Constructor without parameter");
            Display();
        }
        public void Display()
        {
             Console.WriteLine("Type:" + type);
             Console.WriteLine("Wood:" + wood);
             Console.WriteLine("Price:" + price);

        }
    }
}
