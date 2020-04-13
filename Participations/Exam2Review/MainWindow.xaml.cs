using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Exam2Review
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
            string[] pieces = lines.Split('|');
            foreach (var piece in pieces)
            {
                Employee emp = new Employee();
                emp.FirstName = pieces[5];
                emp.LastName = pieces[6];
                emp.Email = pieces[7];
                emp.Gender = pieces[8];
                //emp.Salary = Convert.ToDouble(pieces[9].Remove(0, 1));


            }
            //string path = @"C:\Users\Lakin\Downloads\Employees.txt";
            //string lines = File.ReadAllText(path);
            //string [] pieces = lines.Split('|');
            foreach (var piece in pieces)
            {
                if (piece.Contains("@dropbox.com"))
                {
                    lstEmail.Items.Add(piece);
                }

            }

            avgSalary.Text = "80,000";

        }

        private void lstSalary_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstEmail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void avgSalary_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
