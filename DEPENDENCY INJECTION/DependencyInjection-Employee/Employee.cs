using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_Employee
{
    class Employee
    {
        public int empId;
        public string empName;
        public string gender;
        public int age;
        public double salary { get; set; }
        public string dept { get; set; }
        public string org = "EY";
        public Employee(int empId, string empName, string gender, int age, IEmail mailobj )
        {
            this.empId = empId;
            this.empName = empName;
            this.gender = gender;
            this.age = age;
            mailobj.SendEmail(empName);
        }

        public void getDetails()
        {
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Employee Gender : " + gender);
            Console.WriteLine("Employee Age : " + age);
            Console.WriteLine("Employee Org : " + org);
        }

    }
}
