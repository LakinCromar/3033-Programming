using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Windows;
using Newtonsoft.Json;

namespace WPF_JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string apiURL = "https://rickandmortyapi.com/api/character/";
            RickMortyAPI apiInfo;
            using (var client = new HttpClient()) 
            {
                string json = client.GetStringAsync(apiURL).Result;

                apiInfo = JsonConvert.DeserializeObject<RickMortyAPI>(json);
            }
            foreach (var charater in apiInfo.results)
            {
                lsbchar.Items.Add(charater);
            }
            

        }

        private void lsbchar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultObject selectedchar = (ResultObject)lsbchar.SelectedItem;
            //selectedchar.image;
            imgchar.Source = new BitmapImage(new System.Uri(selectedchar.image));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultObject selectedchar = (ResultObject)lsbchar.SelectedItem;
            //().source = new 
        }
    }
}
