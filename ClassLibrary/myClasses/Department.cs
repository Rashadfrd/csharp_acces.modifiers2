using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.myClasses
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit = 2;
        public int SalaryLimit = 1600;
        public int OverallSalary;
        private Employee[] _employees = new Employee[0];

        public Employee[] employees
        {
            get => _employees;
        }

        public Employee[] AddEmployee (Employee employee)
        {
            if (_employees.Length < EmployeeLimit )
            {
                OverallSalary += employee.Salary;
                if (OverallSalary < SalaryLimit)
                {
                    Array.Resize(ref _employees, _employees.Length + 1);
                    _employees[_employees.Length - 1] = employee;

                    return _employees;
                }
            }
            return _employees;
        }
    }
}
