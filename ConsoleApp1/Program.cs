using ClassLibrary.myClasses;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            department.AddEmployee(new Employee { Name = "Akif", Surname = "Maldini", Salary = 600 });
            department.AddEmployee(new Employee { Name = "Fasif", Surname = "Shevchenko", Salary = 900 });
            department.AddEmployee(new Employee { Name = "Makif", Surname = "Drogba", Salary = 300 });
            department.AddEmployee(new Employee { Name = "Zakif", Surname = "Schweinsteiger", Salary = 290 });

            Console.WriteLine("Isciler:");
            foreach (var item in department.employees)
            {
                Console.WriteLine($"Ad: {item.Name} - Soyad: {item.Surname} - Maas: {item.Salary}");
            }
        }
    }
}
