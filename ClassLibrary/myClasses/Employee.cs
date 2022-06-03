using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.myClasses
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;


        public string Name
        {
            get => _name;
            set
            {
                if (OnlyLetter(value) && StartsWithUpper(value))
                {
                    _name = value;
                }
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (OnlyLetter(value) && StartsWithUpper(value))
                {
                    _surname = value;
                }
            }
        }


        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
            }
        }




        public bool OnlyLetter(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsDigit(name[i]))
                        return false;
                    
                }
            }
            return true;
        }

        public bool StartsWithUpper(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (char.IsUpper(name[0]))
                    return true;

            }
            return false;
        }
    }
}
