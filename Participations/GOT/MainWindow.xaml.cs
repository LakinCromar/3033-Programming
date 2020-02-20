using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace GOT
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

        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://got-quotes.herokuapp.com/quotes";

            GOT gotQuotes;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                gotQuotes = JsonConvert.DeserializeObject<GOT>(json);
            }
            txtQuote.Text = gotQuotes.Quote;
            txtChar.Text = gotQuotes.Character;
        }
    }
}
