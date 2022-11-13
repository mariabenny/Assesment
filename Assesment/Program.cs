// See https://aka.ms/new-console-template for more information

//using Assesment;

//var e1 = new Employee();
//e1.GetData();
//Console.WriteLine($"Name: {e1.Name}");
//Console.WriteLine($"Department: {e1.Department}");
//Console.WriteLine($"Designation: {e1.Designation}");
//Console.WriteLine($"Salary: {e1.Salary}");

//using Assesment;

//var phn = new Mobile();
//phn.Readdata();
//phn.Readdata("mob1", "s6", 60000, "Samsung");
//phn.Readdata("mob2", 30000, "Samsung");

//using Assesment;

//var an = new Animal();
//an.set();

//using Assesment;

//var furn = new Furniture();
//var furn1 = new Furniture("Oak");

//using Assesment;

//var food = new Food("noodles",200);
//Console.WriteLine("Name " + food.Name);
//Console.WriteLine("Discount " + food.Discount);
//Console.WriteLine("Price after discount " + food.Price);

//using Assesment;

//var cloth = new Cloth("new",200);

//Console.WriteLine(cloth.Stock);   
//Console.WriteLine(cloth.Sale);

//FIZZBUZZ


//for (int i = 1; i <= 50; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0) 
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");

//    }
//    else if (i % 5 == 0) 
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}

using Assesment;

var b = new Banking();
b.CreateAccount();
b.DepositCash();
b.WithdrawCash();
b.Balance();

