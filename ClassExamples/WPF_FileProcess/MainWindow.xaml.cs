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

namespace WPF_FileProcess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnPride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();

            var bookcontents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            r.Text = bookcontents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.BurlyWood;

            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            txtRB.Document = fd;
        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            //string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"";
            string path = @"C:\Users\Lakin\Downloads\SalesJan2009.csv";
            var contents = File.ReadAllLines(path);

            //lstBox.Items.Add(contents);
            foreach (var item in contents)
            {
                
                var pieces = item.Split(',');
                lstBox.Items.Add(pieces);
                //double prices;
                //double.TryParse();
                //lstBox.Items.Add()
            }
          
            MessageBox.Show("Read Successfully");
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
