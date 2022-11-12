using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        private string _designation;


        public string Designation 
        {
                get
                {
                  return _designation;
                }
                set
                {
                _designation = value;
                if (value == "trainee")
                    { 
                        _salary = 5000;
                        return;
                    }
                    else if (value == "Senior Employee")
                    {
                        _salary = 50000;
                        return;
                    }
                    else if (value == "Manager")
                    {  
                        _salary = 95000;
                        return;
                    }
                    else
                    {
                        _salary = 0;
                        return;
                    }
                }
            }

        private int _salary;
        public int Salary {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;    
            }
        }


        public void GetData()
        {
            Console.WriteLine("Enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter the Designation");
            Designation = Console.ReadLine();

        }
    }
}
