using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }

        public Food(string name, float price)
        {   
            Name = name;
            Price = price;
            if (Price > 150)
            {
                Discount = 10;
                Price = Price - (Price * 10) / 100;
            }
        }

    }
}
