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

namespace JSONExample
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
            PokemonAPI pokeAPI;
          
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;
                pokeAPI = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }
            foreach (var poke in pokeAPI.results)
            {
                lstPokemon.Items.Add(poke);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path2 = $"https://pokeapi.co/api/v2/pokemon/{lstPokemon.SelectedItem}";
            PokemonAPI pokeAPI2;
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(path2).Result;
                pokeAPI2 = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            //lstPokemon.SelectedItem
        }
    }
}
