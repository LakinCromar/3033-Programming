using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeFile
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Gender = "";
            Salary = 0;
        }
        public Employee(string firstname, string lastname, string email, string gender, string salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Gender = gender;
            Salary = Convert.ToDouble(salary.Replace("$", ""));
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Gender}) makes {Salary.ToString("C2")} contact them at {Email}";
        }
    

    }
}
