using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = @"C:\Users\Lakin\Downloads\Employees.txt";
            var lines = File.ReadAllLines(path);
           
            List<Employee> emps = new List<Employee>();
            for (int i = 1; i < lines.Length; i++)
            {
               var line = lines[i].Split('|');
               emps.Add(new Employee(line[0], line[1], line[2], line[3], line[4]));
            }

            double addedsalaries = 0;
            foreach (var emp in emps)
            {
                if (emp.Salary > 70000)
                {
                    lstSalary.Items.Add(emp);
                }

                if (emp.Email.Contains("@dropbox.com"))
                {
                    lstEmail.Items.Add(emp);
                }
                addedsalaries += emp.Salary; 
            }  
            double avgsalary = addedsalaries / emps.Count;
            txtavgsal.Text = avgsalary.ToString("C2");
        }
    }
}
