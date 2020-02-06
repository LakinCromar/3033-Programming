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

namespace ClickTheButton
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(grdMain.ActualWidth - submitbtn.Width);
            int y = Convert.ToInt32(grdMain.ActualHeight - submitbtn.Height);
            Random rand = new Random();
        
            //double y = grdMain.ActualWidth;
            submitbtn.Margin = new Thickness(rand.Next(y), rand.Next(x), 0, 0);

        }

        private void grdMain_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl.Content = $"X: {e.GetPosition(grdMain).X} Y: {e.GetPosition(grdMain).Y}";
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
