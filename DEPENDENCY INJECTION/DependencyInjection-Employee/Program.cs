using System;

namespace DependencyInjection_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Initializing!");
            
            
            Console.WriteLine("---------------------");
            IEmail mailobj = new OutlookEmail();
            Employee emp1 = new Employee(1000,"Gokul","M",30, mailobj);
            emp1.getDetails();
            Console.WriteLine("---------------------");
            IEmail mailobj1 = new ShellEmail();
            //IEmail mailobj2 = new WebEmail();
            Employee emp2 = new Employee(1001, "Haggy", "F", 30, mailobj1);
            emp2.getDetails();
            Console.WriteLine("---------------------");

            Console.ReadLine();
        }
    }
}
