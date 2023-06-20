using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace API_WPFClient
{
	public partial class UpdateWindow : Window
	{
		private const string ApiUrl = "http://localhost:3001";
		public UpdateWindow()
		{
			InitializeComponent();
		}
		private async void GetDataButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					HttpResponseMessage response = await client.GetAsync(ApiUrl + "/getcountry/" + CountryTextBox.Text);
					response.EnsureSuccessStatusCode(); 

					string jsonString = await response.Content.ReadAsStringAsync();

					Country data = JsonConvert.DeserializeObject<Country>(jsonString);

					CountryTextBox.Text = data.Countryname;
					CapitalTextBox.Text = data.Capital;
					ContinentTextBox.Text = data.Continent;
					PopulationTextBox.Text = data.Population.ToString();
					CurrencyTextBox.Text = data.Currency;
					string common_languages = String.Join(", ", data.Common_languages);
					CommonLanguagesTextBox.Text = common_languages;
					ImagesourceTextBox.Text = data.Imagesource;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
		private async void SendDataButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					string[] common_languages = CommonLanguagesTextBox.Text.Split(',');

					Country country = new Country
					{
						Countryname = CountryTextBox.Text,
						Capital = CapitalTextBox.Text,
						Continent = ContinentTextBox.Text,
						Population = int.Parse(PopulationTextBox.Text),
						Currency = CurrencyTextBox.Text,
						Common_languages = common_languages,
						Imagesource = ImagesourceTextBox.Text
					};

					string jsonString = JsonConvert.SerializeObject(country);

					string updateEndpoint = "/updateCountry/" + CountryTextBox.Text;

					HttpResponseMessage response = await client.PutAsJsonAsync(ApiUrl + updateEndpoint, country);
					response.EnsureSuccessStatusCode();

					MessageBox.Show("Data sent successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
