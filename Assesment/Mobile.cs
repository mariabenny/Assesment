using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Mobile
    {
        public String name;
        public String model;
        public int prize;
        public String company;
        public void Readdata()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the model");
            model = Console.ReadLine();
            Console.WriteLine("Enter the prize");
            prize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the company");
            company = Console.ReadLine();
            SetData();



        }
        private void SetData()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Prize:" + prize);
            Console.WriteLine("Company:" + company);
        }
        public void Readdata(string MName, String MModel, int MPrize, String MCompany)
        {
            Console.WriteLine("4 parameter");
            name = MName;
            model = MModel;
            prize = MPrize;
            company = MCompany;
            SetData();



        }
        public void Readdata(string MName, int MPrize, String MCompany)
        {
            Console.WriteLine("3 parameter");
            name = MName;
            prize = MPrize;
            company = MCompany;
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Prize:" + prize);
            Console.WriteLine("Company:" + company);



        }
    }
}
