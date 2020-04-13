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
            string lines = File.ReadAllText(path);
           
            List<Employee> emps = new List<Employee>();
            for (int i = 1; i < lines.Length; i++)
            {
               var line = lines[i].Split('|');
               emps.Add(new Employee(line[0], line[1], line[2], line[3], line[4]));
            }


            foreach (var emp in emps)
            {

            }
        }
    }
}
