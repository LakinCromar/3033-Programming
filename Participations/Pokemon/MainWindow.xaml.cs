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

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = "https://pokeapi.co/api/v2/pokemon";
            AllPokemonAPI pokemonAPI;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;
                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }
            foreach (var pokie in pokemonAPI.results)
            {
                lstPokies.Items.Add(pokie);
            }
        }

        private void lstPokies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void btnpokie_Click(object sender, RoutedEventArgs e)
        {
            //var selectedpokie = (AllPokemonResult)lstPokies.SelectedItem;
            string path2 = $"https://pokeapi.co/api/v2/pokemon/{lstPokies.SelectedItem}";
            PokeAPI pokemonAPI2;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path2).Result;
                pokemonAPI2 = JsonConvert.DeserializeObject<PokeAPI>(json);
            }
            txth.Text = Convert.ToString(pokemonAPI2.height);
            txtwght.Text = Convert.ToString(pokemonAPI2.weight);

            //img.Source = new BitmapImage(new Uri(lstPokies.SelectedItem.front_defult));
        }
    }
}
