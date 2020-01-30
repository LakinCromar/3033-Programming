using System;
using System.Collections.Generic;
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

namespace WPF
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EntryForm entry = new EntryForm();
            entry.Name = TBName.Text;
            entry.Address = TBAddress.Text;
            entry.ZipCode = Convert.ToInt32(TBZipcode.Text);
            LB.Items.Add(entry.ToString());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
        
    }
}
